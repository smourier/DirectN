using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static partial class WICFunctions
    {
        public static IComObject<IWICBitmapSource> LoadBitmapSource(string filePath, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
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

        public static IComObject<IWICBitmapSource> LoadBitmapSource(Stream stream, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
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

        public static IComObject<IWICColorContext> CreateColorContext()
        {
            var wfac = (IWICImagingFactory)new WICImagingFactory();
            try
            {
                wfac.CreateColorContext(out var context).ThrowOnError();
                return new ComObject<IWICColorContext>(context);
            }
            finally
            {
                ComObject.Release(wfac);
            }
        }

        public static IComObject<IWICColorContext> CreateColorContext(uint exifColorSpace)
        {
            var context = CreateColorContext();
            context.Object.InitializeFromExifColorSpace(exifColorSpace).ThrowOnError();
            return context;
        }

        public static IComObject<IWICColorContext> CreateColorContext(string fileName)
        {
            if (fileName == null)
                throw new ArgumentNullException(nameof(fileName));

            var context = CreateColorContext();
            context.Object.InitializeFromFilename(fileName).ThrowOnError();
            return context;
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
