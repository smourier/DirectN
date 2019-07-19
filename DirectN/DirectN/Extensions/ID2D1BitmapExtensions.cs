using System;

namespace DirectN
{
    public static class ID2D1BitmapExtensions
    {
        public static D2D_SIZE_F GetDpi(this ComObject<ID2D1Bitmap> bitmap) => GetDpi(bitmap?.Object);
        public static D2D_SIZE_F GetDpi(this ID2D1Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

#pragma warning disable CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            bitmap.GetDpi(out var dx, out var dy);
#pragma warning restore CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            return new D2D_SIZE_F(dx, dy);
        }

        public static D2D_SIZE_F GetSize(this ComObject<ID2D1Bitmap> bitmap) => GetSize(bitmap?.Object);
        public static D2D_SIZE_F GetSize(this ID2D1Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            // if this doesn't compile, you must change ID2B1Bitmap method like this:
            // [PreserveSig]
            // void GetSize(out D2D_SIZE_F size);
#pragma warning disable CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            bitmap.GetSize(out var size);
#pragma warning restore CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute
            return size;
        }
    }
}
