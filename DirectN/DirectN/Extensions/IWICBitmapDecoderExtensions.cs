using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    public static class IWICBitmapDecoderExtensions
    {
        public static Guid GetContainerFormat(this IComObject<IWICBitmapDecoder> decoder) => GetContainerFormat(decoder?.Object);
        public static Guid GetContainerFormat(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetContainerFormat(out var value).ThrowOnError();
            return value;
        }

        public static int GetFrameCount(this IComObject<IWICBitmapDecoder> decoder) => GetFrameCount(decoder?.Object);
        public static int GetFrameCount(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetFrameCount(out var value).ThrowOnError();
            return (int)value;
        }

        public static IComObject<IWICBitmapFrameDecode> GetFrame(this IComObject<IWICBitmapDecoder> decoder, int index) => GetFrame(decoder?.Object, index);
        public static IComObject<IWICBitmapFrameDecode> GetFrame(this IWICBitmapDecoder decoder, int index)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetFrame((uint)index, out var value).ThrowOnError();
            return new ComObject<IWICBitmapFrameDecode>(value);
        }

        public static IComObject<IWICMetadataQueryReader> GetMetadataQueryReader(this IComObject<IWICBitmapDecoder> decoder) => GetMetadataQueryReader(decoder?.Object);
        public static IComObject<IWICMetadataQueryReader> GetMetadataQueryReader(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetMetadataQueryReader(out var value).ThrowOnError();
            return new ComObject<IWICMetadataQueryReader>(value);
        }

        public static IComObject<IWICBitmapDecoderInfo> GetDecoderInfo(this IComObject<IWICBitmapDecoder> decoder) => GetDecoderInfo(decoder?.Object);
        public static IComObject<IWICBitmapDecoderInfo> GetDecoderInfo(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetDecoderInfo(out var value).ThrowOnError();
            return new ComObject<IWICBitmapDecoderInfo>(value);
        }

        public static IComObject<IWICBitmapSource> GetThumbnail(this IComObject<IWICBitmapDecoder> decoder) => GetThumbnail(decoder?.Object);
        public static IComObject<IWICBitmapSource> GetThumbnail(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetThumbnail(out var value).ThrowOnError(false);
            if (value == null)
                return null;

            return new ComObject<IWICBitmapSource>(value);
        }

        public static IComObject<IWICBitmapSource> GetPreview(this IComObject<IWICBitmapDecoder> decoder) => GetPreview(decoder?.Object);
        public static IComObject<IWICBitmapSource> GetPreview(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetPreview(out var value).ThrowOnError(false);
            if (value == null)
                return null;

            return new ComObject<IWICBitmapSource>(value);
        }

        public static WICBitmapDecoderCapabilities QueryCapability(this IComObject<IWICBitmapDecoder> decoder, IStream stream) => QueryCapability(decoder?.Object, stream);
        public static WICBitmapDecoderCapabilities QueryCapability(this IWICBitmapDecoder decoder, IStream stream)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            decoder.QueryCapability(stream, out var capabilities).ThrowOnError(false);
            return (WICBitmapDecoderCapabilities)capabilities;
        }

        public static void CopyPalette(this IComObject<IWICBitmapDecoder> decoder, IWICPalette palette) => CopyPalette(decoder?.Object, palette);
        public static void CopyPalette(this IWICBitmapDecoder decoder, IWICPalette palette)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.CopyPalette(palette).ThrowOnError(false);
        }

        public static void Initialize(this IComObject<IWICBitmapDecoder> decoder, IStream stream, WICDecodeOptions options) => Initialize(decoder?.Object, stream, options);
        public static void Initialize(this IWICBitmapDecoder decoder, IStream stream, WICDecodeOptions options)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            decoder.Initialize(stream, options).ThrowOnError(false);
        }

        public static IComObject<IWICColorContext>[] GetColorContexts(this IComObject<IWICBitmapDecoder> decoder) => GetColorContexts(decoder?.Object);
        public static IComObject<IWICColorContext>[] GetColorContexts(this IWICBitmapDecoder decoder)
        {
            if (decoder == null)
                throw new ArgumentNullException(nameof(decoder));

            decoder.GetColorContexts(0, null, out var count);
            if (count == 0)
                return Array.Empty<IComObject<IWICColorContext>>();

            var colorContexts = WICImagingFactory.CreateColorContexts((int)count);
            decoder.GetColorContexts(colorContexts.Length, colorContexts.Select(cc => cc.Object).ToArray(), out _).ThrowOnError();
            return colorContexts;
        }
    }
}
