using System;

namespace DirectN
{
    public static class ID2D1BitmapExtensions
    {
        public static D2D_SIZE_F GetDpi(this IComObject<ID2D1Bitmap> bitmap) => GetDpi(bitmap?.Object);
        public static D2D_SIZE_F GetDpi(this ID2D1Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            bitmap.GetDpi(out var dx, out var dy);
            return new D2D_SIZE_F(dx, dy);
        }

        public static D2D_SIZE_F GetSize(this IComObject<ID2D1Bitmap> bitmap) => GetSize(bitmap?.Object);
        public static D2D_SIZE_F GetSize(this ID2D1Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            bitmap.GetSize(out var size);
            return size;
        }

        public static D2D_SIZE_U GetPixelSize(this IComObject<ID2D1Bitmap> bitmap) => GetPixelSize(bitmap?.Object);
        public static D2D_SIZE_U GetPixelSize(this ID2D1Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            bitmap.GetPixelSize(out var size);
            return size;
        }

        public static D2D1_PIXEL_FORMAT GetPixelFormat(this IComObject<ID2D1Bitmap> bitmap) => GetPixelFormat(bitmap?.Object);
        public static D2D1_PIXEL_FORMAT GetPixelFormat(this ID2D1Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            bitmap.GetPixelFormat(out var format);
            return format;
        }
    }
}
