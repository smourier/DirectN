using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
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

        public void Read(byte[] pv, int cb, IntPtr pcbRead)
        {
            if (pv == null)
                throw new ArgumentNullException(nameof(pv));

            var read = _stream.Read(pv, 0, cb);
            if (pcbRead != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbRead, read);
            }
        }

        public void Write(byte[] pv, int cb, IntPtr pcbWritten)
        {
            if (pv == null)
                throw new ArgumentNullException(nameof(pv));

            _stream.Write(pv, 0, cb);
            if (pcbWritten != IntPtr.Zero)
            {
                Marshal.WriteInt32(pcbWritten, cb);
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
        public void Commit(int grfCommitFlags) => _stream.Flush();
        public void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag)
        {
            pstatstg = new System.Runtime.InteropServices.ComTypes.STATSTG
            {
                type = (int)STGTY.STGTY_STREAM,
                cbSize = _stream.Length,
                grfMode = 0
            };

            if (_stream.CanRead && _stream.CanWrite)
            {
                pstatstg.grfMode |= (int)STGM.STGM_READWRITE;
                return;
            }

            if (_stream.CanRead)
            {
                pstatstg.grfMode |= (int)STGM.STGM_READ;
                return;
            }

            if (_stream.CanWrite)
            {
                pstatstg.grfMode |= (int)STGM.STGM_WRITE;
                return;
            }

            throw new IOException();
        }

        public void CopyTo(IStream pstm, long cb, IntPtr pcbRead, IntPtr pcbWritten)
        {
            if (pstm == null)
                throw new ArgumentNullException(nameof(pstm));

            long count;
            using (var stream = new StreamOnIStream(pstm))
            {
                count = _stream.CopyTo(stream, cb);
            }

            if (pcbRead != IntPtr.Zero)
            {
                Marshal.WriteInt64(pcbRead, count);
            }

            if (pcbWritten != IntPtr.Zero)
            {
                Marshal.WriteInt64(pcbWritten, count);
            }
        }

        public void Revert() => throw new NotSupportedException();
        public void LockRegion(long libOffset, long cb, int dwLockType) => throw new NotSupportedException();
        public void UnlockRegion(long libOffset, long cb, int dwLockType) => throw new NotSupportedException();
        public void Clone(out IStream ppstm) => throw new NotSupportedException();
    }
}
