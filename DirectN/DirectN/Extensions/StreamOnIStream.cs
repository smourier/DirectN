using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace DirectN
{
    public class StreamOnIStream : Stream
    {
        private const int STATFLAG_NONAME = 1;
        private IStream _stream;
        private IntPtr _ptr;
        private long _position;

        public StreamOnIStream(IStream stream, bool releaseOnDispose = false)
        {
            _stream = stream;
            _ptr = Marshal.AllocCoTaskMem(8); // works for 32b & 64b
            ReleaseOnDispose = releaseOnDispose;
            CanRead = true;
            CanSeek = true;
            CanWrite = true;
        }

        public IStream NativeStream => CheckDisposed();
        public bool ReleaseOnDispose { get; }
        public override bool CanTimeout => false;
        public override int ReadTimeout => Timeout.Infinite;
        public override int WriteTimeout => Timeout.Infinite;
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Position { get => _position; set => Seek(value, SeekOrigin.Begin); }
        public override long Length
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return stat.cbSize;
            }
        }

        public DateTimeOffset LastWriteTime
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return stat.mtime.ToDateTimeOffset();
            }
        }

        public DateTimeOffset LastAccessTime
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return stat.atime.ToDateTimeOffset();
            }
        }

        public Guid Clsid
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return stat.clsid;
            }
        }

        public string Name
        {
            get
            {
                CheckDisposed().Stat(out var stat, 0);
                return stat.pwcsName;
            }
        }

        public DateTimeOffset CreationTime
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return stat.ctime.ToDateTimeOffset();
            }
        }

        public STGM StorageMode
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return (STGM)stat.grfMode;
            }
        }

        public STGTY StorageType
        {
            get
            {
                CheckDisposed().Stat(out var stat, STATFLAG_NONAME);
                return (STGTY)stat.type;
            }
        }

        public virtual void Flush(STGC options) => CheckDisposed().Commit((int)options);
        public override void Flush() => Flush(STGC.STGC_DEFAULT);

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(offset));

            if (count == 0)
                return 0;

            if (offset == 0)
                return Read(buffer, count);

            var bytes = new byte[count];
            var read = Read(bytes, bytes.Length);
            if (read > 0)
            {
                Array.Copy(bytes, 0, buffer, offset, read);
            }
            return read;
        }

        private int Read(byte[] buffer, int count)
        {
            CheckDisposed().Read(buffer, count, _ptr);
            var read = Marshal.ReadInt32(_ptr);
            _position += read;
            return read;
        }

        public override void SetLength(long value) => CheckDisposed().SetSize(value);
        public override long Seek(long offset, SeekOrigin origin)
        {
            CheckDisposed().Seek(offset, (int)origin, _ptr);
            _position = Marshal.ReadInt64(_ptr);
            return _position;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset));

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(offset));

            if (count == 0)
                return;

            if (offset == 0)
            {
                CheckDisposed().Write(buffer, count, _ptr);
            }
            else
            {
                var bytes = new byte[count];
                Array.Copy(buffer, offset, bytes, 0, count);
                CheckDisposed().Write(bytes, bytes.Length, _ptr);
            }

            var written = Marshal.ReadInt32(_ptr);
            _position += written;
        }

        private IStream CheckDisposed()
        {
            var stream = _stream;
            if (stream == null)
                throw new ObjectDisposedException(nameof(NativeStream));

            return stream;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            var stream = Interlocked.Exchange(ref _stream, null);
            if (stream != null)
            {
                try
                {
                    stream.Commit((int)STGC.STGC_DEFAULT);
                    if (ReleaseOnDispose)
                    {
                        Marshal.ReleaseComObject(stream);
                    }
                }
                catch
                {
                    //+ do nothing
                }
            }

            var ptr = Interlocked.Exchange(ref _ptr, IntPtr.Zero);
            if (ptr != IntPtr.Zero)
            {
                Marshal.FreeCoTaskMem(ptr);
            }
        }
    }
}
