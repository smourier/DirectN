using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace DirectN
{
    public sealed class ManagedIStream : System.Runtime.InteropServices.ComTypes.IStream, IDisposable
    {
        private Stream _stream;
        private readonly bool _owned;

        public ManagedIStream(Stream stream, bool owned = false)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            _stream = stream;
            _owned = owned;
        }

        public ManagedIStream(string text, Encoding encoding = null)
            : this(GetStream(text, encoding), true)
        {
        }

        private static Stream GetStream(string text, Encoding encoding)
        {
            if (!string.IsNullOrEmpty(text))
            {
                encoding = encoding ?? Encoding.Unicode;
                return new MemoryStream(encoding.GetBytes(text));
            }

            return new MemoryStream();
        }

        public void Clone(out System.Runtime.InteropServices.ComTypes.IStream ppstm) => throw new NotSupportedException();
        public void CopyTo(System.Runtime.InteropServices.ComTypes.IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten) => throw new NotSupportedException();
        public void LockRegion(long libOffset, long cb, int dwLockType) => throw new NotSupportedException();
        public void UnlockRegion(long libOffset, long cb, int dwLockType) => throw new NotSupportedException();
        public void Revert() => throw new NotSupportedException();

        public void Commit(int grfCommitFlags)
        {
            // do nothing
        }

        public void Read(byte[] pv, int cb, IntPtr pcbRead)
        {
            var read = _stream.Read(pv, 0, cb);
            if (pcbRead != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbRead, read);
            }
        }

        public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
        {
            var newPos = _stream.Seek(dlibMove, (SeekOrigin)dwOrigin);
            if (plibNewPosition != IntPtr.Zero)
            {
                Marshal.WriteInt64(plibNewPosition, newPos);
            }
        }

        public void Dispose()
        {
            if (_owned)
            {
                Interlocked.Exchange(ref _stream, null)?.Dispose();
            }
        }

        public void SetSize(long libNewSize) => _stream.SetLength(libNewSize);

        public void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag)
        {
            const int STGTY_STREAM = 2;
            pstatstg = new System.Runtime.InteropServices.ComTypes.STATSTG();
            pstatstg.type = STGTY_STREAM;
            pstatstg.cbSize = _stream.Length;
            pstatstg.grfMode = 0;

            if (_stream.CanRead && _stream.CanWrite)
            {
                const int STGM_READWRITE = 0x00000002;
                pstatstg.grfMode |= STGM_READWRITE;
                return;
            }

            if (_stream.CanRead)
            {
                const int STGM_READ = 0x00000000;
                pstatstg.grfMode |= STGM_READ;
                return;
            }

            if (_stream.CanWrite)
            {
                const int STGM_WRITE = 0x00000001;
                pstatstg.grfMode |= STGM_WRITE;
                return;
            }

            throw new IOException();
        }

        public void Write(byte[] pv, int cb, IntPtr pcbWritten)
        {
            _stream.Write(pv, 0, cb);
            if (pcbWritten != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbWritten, cb);
            }
        }
    }
}
