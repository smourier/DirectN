using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    public static class IWICBitmapEncoderExtensions
    {
        public static WICBitmapFrameEncode CreateNewFrame(this IComObject<IWICBitmapEncoder> encoder) => CreateNewFrame(encoder?.Object);
        public static WICBitmapFrameEncode CreateNewFrame(this IWICBitmapEncoder encoder)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.CreateNewFrame(out var frame, out var bag).ThrowOnError();
            return new WICBitmapFrameEncode(frame, bag);
        }

        public static void Initialize(this IComObject<IWICBitmapEncoder> encoder, IStream stream, WICBitmapEncoderCacheOption options = WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache) => Initialize(encoder?.Object, stream, options);
        public static void Initialize(this IWICBitmapEncoder encoder, IStream stream, WICBitmapEncoderCacheOption options = WICBitmapEncoderCacheOption.WICBitmapEncoderNoCache)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            encoder.Initialize(stream, options).ThrowOnError();
        }

        public static void Commit(this IComObject<IWICBitmapEncoder> encoder) => Commit(encoder?.Object);
        public static void Commit(this IWICBitmapEncoder encoder)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.Commit().ThrowOnError();
        }

        public static void SetColorContexts(this IComObject<IWICBitmapEncoder> encoder, IEnumerable<IWICColorContext> contexts) => SetColorContexts(encoder?.Object, contexts);
        public static void SetColorContexts(this IWICBitmapEncoder encoder, IEnumerable<IWICColorContext> contexts)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.SetColorContexts((contexts?.Count()).GetValueOrDefault(), contexts?.ToArray()).ThrowOnError();
        }

        public static void SetPalette(this IComObject<IWICBitmapEncoder> encoder, IComObject<IWICPalette> palette) => SetPalette(encoder?.Object, palette?.Object);
        public static void SetPalette(this IWICBitmapEncoder encoder, IWICPalette palette)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.SetPalette(palette).ThrowOnError();
        }

        public static void SetPreview(this IComObject<IWICBitmapEncoder> encoder, IComObject<IWICBitmapSource> preview) => SetPreview(encoder?.Object, preview?.Object);
        public static void SetPreview(this IWICBitmapEncoder encoder, IWICBitmapSource preview)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.SetPreview(preview).ThrowOnError();
        }

        public static void SetThumbnail(this IComObject<IWICBitmapEncoder> encoder, IComObject<IWICBitmapSource> thumbnail) => SetThumbnail(encoder?.Object, thumbnail?.Object);
        public static void SetThumbnail(this IWICBitmapEncoder encoder, IWICBitmapSource thumbnail)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.SetThumbnail(thumbnail).ThrowOnError();
        }

        public static Guid GetContainerFormat(this IComObject<IWICBitmapEncoder> encoder) => GetContainerFormat(encoder?.Object);
        public static Guid GetContainerFormat(this IWICBitmapEncoder encoder)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.GetContainerFormat(out var guid).ThrowOnError();
            return guid;
        }

        public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IComObject<IWICBitmapEncoder> encoder) => GetMetadataQueryWriter(encoder?.Object);
        public static IComObject<IWICMetadataQueryWriter> GetMetadataQueryWriter(this IWICBitmapEncoder encoder)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.GetMetadataQueryWriter(out var writer).ThrowOnError();
            return new ComObject<IWICMetadataQueryWriter>(writer);
        }

        public static IComObject<IWICBitmapEncoderInfo> GetEncoderInfo(this IComObject<IWICBitmapEncoder> encoder) => GetEncoderInfo(encoder?.Object);
        public static IComObject<IWICBitmapEncoderInfo> GetEncoderInfo(this IWICBitmapEncoder encoder)
        {
            if (encoder == null)
                throw new ArgumentNullException(nameof(encoder));

            encoder.GetEncoderInfo(out var info).ThrowOnError();
            return new ComObject<IWICBitmapEncoderInfo>(info);
        }
    }
}
