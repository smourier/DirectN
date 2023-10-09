using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace DirectN
{
    public sealed class UnmanagedMemoryStream : Stream, IStream
    {
        private IStream _stream;
        private long _position;

        public UnmanagedMemoryStream()
        {
            _stream = SHCreateMemStream(IntPtr.Zero, 0);
            Check();
            Position = 0;
        }

        public UnmanagedMemoryStream(Stream stream, int bufferSize = 81920) // below LOH
            : this()
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            if (bufferSize < 1)
                throw new ArgumentOutOfRangeException(nameof(bufferSize));

            stream.CopyTo(this, bufferSize);
            Position = 0;
        }

        public UnmanagedMemoryStream(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            _stream = SHCreateMemStream(bytes, bytes.Length);
            Check();
            Position = 0;
        }

        public UnmanagedMemoryStream(IntPtr pointer, uint size)
        {
            if (pointer == IntPtr.Zero)
                throw new ArgumentException(null, nameof(pointer));

            _stream = SHCreateMemStream(pointer, size);
            Check();
            Position = 0;
        }

        public IStream NativeStream
        {
            get
            {
                var stream = _stream;
                if (stream == null)
                    throw new ObjectDisposedException(nameof(NativeStream));

                return stream;
            }
        }

        public override long Length
        {
            get
            {
                NativeStream.Stat(out var stat, 0);
                return stat.cbSize;
            }
        }

        public override bool CanTimeout => false;
        public override bool CanRead => true;
        public override bool CanSeek => true;
        public override bool CanWrite => true;

        public override long Position
        {
            get => _position;
            set
            {
                if (Position == value)
                    return;

                Seek(value, SeekOrigin.Begin);
            }
        }

        public override void Flush() => ((IStream)this).Commit(0); // STGC_DEFAULT
        public override void SetLength(long value) => ((IStream)this).SetSize(value);
        public override long Seek(long offset, SeekOrigin origin)
        {
            ((IStream)this).Seek(offset, (int)origin, IntPtr.Zero);
            return _position;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (offset != 0)
                throw new NotSupportedException();

            return Read(buffer, count, IntPtr.Zero);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (offset != 0)
                throw new NotSupportedException();

            ((IStream)this).Write(buffer, count, IntPtr.Zero);
        }

        private void Check()
        {
            if (_stream == null)
                throw new OutOfMemoryException();
        }

        protected override void Dispose(bool disposing)
        {
            var stream = Interlocked.Exchange(ref _stream, null);
            if (stream != null)
            {
                Marshal.ReleaseComObject(stream);
            }
            base.Dispose(disposing);
        }

        [DllImport("shlwapi")]
        private static extern IStream SHCreateMemStream(IntPtr pInit, uint cbInit);

        [DllImport("shlwapi")]
        private static extern IStream SHCreateMemStream(byte[] pInit, int cbInit);

        void IStream.Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
        {
            if (plibNewPosition == IntPtr.Zero)
            {
                using (var mem = new ComMemory(Marshal.SizeOf<long>()))
                {
                    NativeStream.Seek(dlibMove, dwOrigin, mem.Pointer);
                    _position = Marshal.ReadInt64(mem.Pointer);
                }
            }
            else
            {
                NativeStream.Seek(dlibMove, dwOrigin, plibNewPosition);
                _position = Marshal.ReadInt64(plibNewPosition);
            }
        }

        void IStream.Read(byte[] pv, int cb, IntPtr pcbRead) => Read(pv, cb, pcbRead);
        private int Read(byte[] pv, int cb, IntPtr pcbRead)
        {
            int read;
            if (pcbRead == IntPtr.Zero)
            {
                using (var mem = new ComMemory(Marshal.SizeOf<int>()))
                {
                    NativeStream.Read(pv, cb, mem.Pointer);
                    read = Marshal.ReadInt32(mem.Pointer);
                }
            }
            else
            {
                NativeStream.Read(pv, cb, pcbRead);
                read = Marshal.ReadInt32(pcbRead);
            }
            _position += read;
            return read;
        }

        void IStream.Write(byte[] pv, int cb, IntPtr pcbWritten)
        {
            int written;
            if (pcbWritten == IntPtr.Zero)
            {
                using (var mem = new ComMemory(Marshal.SizeOf<int>()))
                {
                    NativeStream.Write(pv, cb, mem.Pointer);
                    written = Marshal.ReadInt32(mem.Pointer);
                }
            }
            else
            {
                NativeStream.Write(pv, cb, pcbWritten);
                written = Marshal.ReadInt32(pcbWritten);
            }
            _position += written;
        }

        void IStream.Clone(out IStream ppstm) => NativeStream.Clone(out ppstm);
        void IStream.Commit(int grfCommitFlags) => NativeStream.Commit(grfCommitFlags);
        void IStream.CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten) => NativeStream.CopyTo(pstm, cb, pcbRead, pcbWritten);
        void IStream.LockRegion(long libOffset, long cb, int dwLockType) => NativeStream.LockRegion(libOffset, cb, dwLockType);
        void IStream.Revert() => NativeStream.Revert();
        void IStream.SetSize(long libNewSize) => NativeStream.SetSize(libNewSize);
        void IStream.Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag) => NativeStream.Stat(out pstatstg, grfStatFlag);
        void IStream.UnlockRegion(long libOffset, long cb, int dwLockType) => NativeStream.UnlockRegion(libOffset, cb, dwLockType);
    }
}
