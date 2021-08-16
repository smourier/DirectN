using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace DirectN
{
    public static class WICFunctions
    {
        public static ComObject<IWICBitmapSource> LoadBitmapSource(string filePath, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
        {
            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            var wfac = (IWICImagingFactory)new WICImagingFactory();
            IWICBitmapDecoder decoder = null;
            IWICBitmapFrameDecode frame = null;
            try
            {
                wfac.CreateDecoderFromFilename(filePath, IntPtr.Zero, (uint)GenericAccessRights.GENERIC_READ, metadataOptions, out decoder).ThrowOnError();
                decoder.GetFrame(0, out frame).ThrowOnError();
                wfac.CreateFormatConverter(out var converter).ThrowOnError();
                var format = WICConstants.GUID_WICPixelFormat32bppPBGRA;
                converter.Initialize(frame, ref format, WICBitmapDitherType.WICBitmapDitherTypeNone, null, 0, WICBitmapPaletteType.WICBitmapPaletteTypeCustom).ThrowOnError();
                return new ComObject<IWICBitmapSource>(converter);
            }
            finally
            {
                ComObject.Release(frame);
                ComObject.Release(decoder);
                ComObject.Release(wfac);
            }
        }

        public static ComObject<IWICBitmapSource> LoadBitmapSource(Stream stream, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            var wfac = (IWICImagingFactory)new WICImagingFactory();
            IWICBitmapDecoder decoder = null;
            IWICBitmapFrameDecode frame = null;
            var mis = new ManagedIStream(stream);
            try
            {
                wfac.CreateDecoderFromStream(mis, IntPtr.Zero, metadataOptions, out decoder).ThrowOnError();
                decoder.GetFrame(0, out frame).ThrowOnError();
                wfac.CreateFormatConverter(out var converter).ThrowOnError();
                var format = WICConstants.GUID_WICPixelFormat32bppPBGRA;
                converter.Initialize(frame, ref format, WICBitmapDitherType.WICBitmapDitherTypeNone, null, 0, WICBitmapPaletteType.WICBitmapPaletteTypeCustom).ThrowOnError();
                return new ComObject<IWICBitmapSource>(converter);
            }
            finally
            {
                ComObject.Release(frame);
                ComObject.Release(decoder);
                ComObject.Release(wfac);
            }
        }

        private class ManagedIStream : System.Runtime.InteropServices.ComTypes.IStream
        {
            private Stream _stream;

            public ManagedIStream(Stream stream)
            {
                _stream = stream;
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

            ~ManagedIStream()
            {
                Interlocked.Exchange(ref _stream, null)?.Dispose();
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

        [Flags]
        private enum GenericAccessRights : uint
        {
            GENERIC_READ = 0x80000000,
            GENERIC_WRITE = 0x40000000,
            GENERIC_EXECUTE = 0x20000000,
            GENERIC_ALL = 0x10000000,

            GENERIC_READ_WRITE = GENERIC_READ | GENERIC_WRITE,
        }

        [ComImport, Guid("CACAF262-9370-4615-A13B-9F5539DA4C0A")]
        private class WICImagingFactory
        {
        }
    }
}
