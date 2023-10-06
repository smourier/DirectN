using System;
using System.Linq;

namespace DirectN
{
    public static class IWICBitmapFrameDecodeExtensions
    {
        public static IComObject<IWICMetadataQueryReader> GetMetadataQueryReader(this IComObject<IWICBitmapFrameDecode> frame) => GetMetadataQueryReader(frame?.Object);
        public static IComObject<IWICMetadataQueryReader> GetMetadataQueryReader(this IWICBitmapFrameDecode frame)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.GetMetadataQueryReader(out var value).ThrowOnError(false);
            if (value == null)
                return null;

            return new ComObject<IWICMetadataQueryReader>(value);
        }

        public static IComObject<IWICBitmapSource> GetThumbnail(this IComObject<IWICBitmapFrameDecode> frame) => GetThumbnail(frame?.Object);
        public static IComObject<IWICBitmapSource> GetThumbnail(this IWICBitmapFrameDecode frame)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.GetThumbnail(out var value).ThrowOnError(false);
            if (value == null)
                return null;

            return new ComObject<IWICBitmapSource>(value);
        }

        public static IComObject<IWICColorContext>[] GetColorContexts(this IComObject<IWICBitmapFrameDecode> frame) => GetColorContexts(frame?.Object);
        public static IComObject<IWICColorContext>[] GetColorContexts(this IWICBitmapFrameDecode frame)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.GetColorContexts(0, null, out var count);
            if (count == 0)
                return Array.Empty<IComObject<IWICColorContext>>();

            var colorContexts = WICImagingFactory.CreateColorContexts((int)count);
            frame.GetColorContexts(colorContexts.Length, colorContexts.Select(cc => cc.Object).ToArray(), out _).ThrowOnError();
            return colorContexts;
        }
    }
}
