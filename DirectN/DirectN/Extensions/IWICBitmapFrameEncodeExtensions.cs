using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class IWICBitmapFrameEncodeExtensions
    {
        public static void Initialize(this WICBitmapFrameEncode frameBag) => Initialize(frameBag?.Encode, frameBag?.Bag);
        public static void Initialize(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IPropertyBag2> bag = null) => Initialize(frame?.Object, bag?.Object);
        public static void Initialize(this IWICBitmapFrameEncode frame, IPropertyBag2 bag = null)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            if (bag != null)
            {
                frame.Initialize(bag).ThrowOnError();
            }
        }

        public static void SetPixelFormat(this WICBitmapFrameEncode frameBag, Guid pixelFormat) => SetPixelFormat(frameBag?.Encode, pixelFormat);
        public static void SetPixelFormat(this IComObject<IWICBitmapFrameEncode> frame, Guid pixelFormat) => SetPixelFormat(frame?.Object, pixelFormat);
        public static void SetPixelFormat(this IWICBitmapFrameEncode frame, Guid pixelFormat)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.SetPixelFormat(pixelFormat).ThrowOnError();
        }

        public static void SetSize(this WICBitmapFrameEncode frameBag, uint width, uint height) => SetSize(frameBag?.Encode, width, height);
        public static void SetSize(this IComObject<IWICBitmapFrameEncode> frame, uint width, uint height) => SetSize(frame?.Object, width, height);
        public static void SetSize(this IWICBitmapFrameEncode frame, uint width, uint height)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.SetSize(width, height).ThrowOnError();
        }

        public static void SetResolution(this WICBitmapFrameEncode frameBag, double dpiX, double dpiY) => SetResolution(frameBag?.Encode, dpiX, dpiY);
        public static void SetResolution(this IComObject<IWICBitmapFrameEncode> frame, double dpiX, double dpiY) => SetResolution(frame?.Object, dpiX, dpiY);
        public static void SetResolution(this IWICBitmapFrameEncode frame, double dpiX, double dpiY)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.SetResolution(dpiX, dpiY).ThrowOnError();
        }

        public static void WriteSource(this WICBitmapFrameEncode frameBag, IComObject<IWICBitmapSource> source, WICRect? sourceRectangle = null) => WriteSource(frameBag?.Encode, source, sourceRectangle);
        public static void WriteSource(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IWICBitmapSource> source, WICRect? sourceRectangle = null) => WriteSource(frame?.Object, source?.Object, sourceRectangle);
        public static void WriteSource(this IWICBitmapFrameEncode frame, IWICBitmapSource source, WICRect? sourceRectangle = null)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            if (source == null)
                throw new ArgumentNullException(nameof(source));

            using (var mem = new ComMemory(sourceRectangle))
            {
                frame.WriteSource(source, mem.Pointer).ThrowOnError();
            }
        }

        public static void WritePixels(this WICBitmapFrameEncode frameBag, uint lineCount, uint stride, byte[] pixels) => WritePixels(frameBag?.Encode, lineCount, stride, pixels);
        public static void WritePixels(this IComObject<IWICBitmapFrameEncode> frame, uint lineCount, uint stride, byte[] pixels) => WritePixels(frame?.Object, lineCount, stride, pixels);
        public static void WritePixels(this IWICBitmapFrameEncode frame, uint lineCount, uint stride, byte[] pixels)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            if (pixels == null)
                throw new ArgumentNullException(nameof(pixels));

            frame.WritePixels(lineCount, stride, pixels.Length, pixels).ThrowOnError();
        }

        public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this WICBitmapFrameEncode frameBag) => GetMetadataQueryWriter(frameBag?.Encode);
        public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IComObject<IWICBitmapFrameEncode> frame) => GetMetadataQueryWriter(frame?.Object);
        public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IWICBitmapFrameEncode frame)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.GetMetadataQueryWriter(out var writer).ThrowOnError();
            return new ComObject<IWICMetadataQueryWriter>(writer);
        }

        public static void Commit(this WICBitmapFrameEncode frameBag) => Commit(frameBag?.Encode);
        public static void Commit(this IComObject<IWICBitmapFrameEncode> frame) => Commit(frame?.Object);
        public static void Commit(this IWICBitmapFrameEncode frame)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.Commit().ThrowOnError();
        }

        public static void SetColorContexts(this WICBitmapFrameEncode frameBag, IEnumerable<IWICColorContext> contexts) => SetColorContexts(frameBag?.Encode, contexts);
        public static void SetColorContexts(this IComObject<IWICBitmapFrameEncode> frame, IEnumerable<IWICColorContext> contexts) => SetColorContexts(frame?.Object, contexts);
        public static void SetColorContexts(this IWICBitmapFrameEncode frame, IEnumerable<IWICColorContext> contexts)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.SetColorContexts((contexts?.Count()).GetValueOrDefault(), contexts?.ToArray()).ThrowOnError();
        }

        public static void SetPalette(this WICBitmapFrameEncode frameBag, IComObject<IWICPalette> palette) => SetPalette(frameBag?.Encode, palette);
        public static void SetPalette(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IWICPalette> palette) => SetPalette(frame?.Object, palette?.Object);
        public static void SetPalette(this IWICBitmapFrameEncode frame, IWICPalette palette)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.SetPalette(palette).ThrowOnError();
        }

        public static void SetThumbnail(this WICBitmapFrameEncode frameBag, IComObject<IWICBitmapSource> thumbnail) => SetThumbnail(frameBag?.Encode, thumbnail);
        public static void SetThumbnail(this IComObject<IWICBitmapFrameEncode> frame, IComObject<IWICBitmapSource> thumbnail) => SetThumbnail(frame?.Object, thumbnail?.Object);
        public static void SetThumbnail(this IWICBitmapFrameEncode frame, IWICBitmapSource thumbnail)
        {
            if (frame == null)
                throw new ArgumentNullException(nameof(frame));

            frame.SetThumbnail(thumbnail).ThrowOnError();
        }
    }
}
