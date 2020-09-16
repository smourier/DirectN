using System;

namespace DirectN
{
    public static class ID2D1RenderTargetExtensions
    {
        public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1RenderTarget> device, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES properties) => CreateBitmap<ID2D1Bitmap>(device?.Object, size, IntPtr.Zero, 0, properties);
        public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1RenderTarget> device, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) => CreateBitmap<ID2D1Bitmap>(device?.Object, size, srcData, pitch, properties);
        public static IComObject<T> CreateBitmap<T>(this IComObject<ID2D1RenderTarget> device, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) where T : ID2D1Bitmap => CreateBitmap<T>(device?.Object, size, srcData, pitch, properties);
        public static IComObject<T> CreateBitmap<T>(this ID2D1RenderTarget device, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) where T : ID2D1Bitmap
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateBitmap(size, srcData, pitch, ref properties, out var bmp).ThrowOnError();
            return new ComObject<T>((T)bmp);
        }

        public static IComObject<ID2D1SolidColorBrush> CreateSolidColorBrush(this IComObject<ID2D1RenderTarget> device, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) => CreateSolidColorBrush<ID2D1SolidColorBrush>(device?.Object, color, properties);
        public static IComObject<T> CreateSolidColorBrush<T>(this IComObject<ID2D1RenderTarget> device, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush => CreateSolidColorBrush<T>(device?.Object, color, properties);
        public static IComObject<T> CreateSolidColorBrush<T>(this ID2D1RenderTarget device, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            if (properties.HasValue)
            {
                using (var props = properties.Value.StructureToMemory())
                {
                    device.CreateSolidColorBrush(ref color, props.Pointer, out var brush).ThrowOnError();
                    return new ComObject<T>((T)brush);
                }
            }

            device.CreateSolidColorBrush(ref color, IntPtr.Zero, out var brush2).ThrowOnError();
            return new ComObject<T>((T)brush2);
        }

        // this one is useless but is consistent with EndDraw
        public static void BeginDraw(this IComObject<ID2D1RenderTarget> device) => BeginDraw(device?.Object);
        public static void BeginDraw(this ID2D1RenderTarget device) => device?.BeginDraw();
        public static void EndDraw(this IComObject<ID2D1RenderTarget> device) => EndDraw(device?.Object);
        public static void EndDraw(this ID2D1RenderTarget device) => device?.EndDraw(IntPtr.Zero, IntPtr.Zero).ThrowOnError();
        public static void Clear(this IComObject<ID2D1RenderTarget> device, _D3DCOLORVALUE? clearColor = null) => Clear(device?.Object, clearColor);
        public static void Clear(this ID2D1RenderTarget device, _D3DCOLORVALUE? clearColor = null)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            if (clearColor.HasValue)
            {
                using (var cc = clearColor.Value.StructureToMemory())
                {
                    device.Clear(cc.Pointer);
                }
                return;
            }
            device.Clear(IntPtr.Zero);
        }

        public static void DrawText(this IComObject<ID2D1RenderTarget> device,
            string text,
            IComObject<IDWriteTextFormat> format,
            D2D_RECT_F rect,
            IComObject<ID2D1Brush> brush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL) => DrawText(device?.Object, text, format?.Object, rect, brush?.Object, options, measuringMode);

        public static void DrawText(this ID2D1RenderTarget device,
            string text,
            IDWriteTextFormat format,
            D2D_RECT_F rect,
            ID2D1Brush brush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            if (format == null)
                throw new ArgumentNullException(nameof(format));

            if (text == null)
                return;

            device.DrawTextW(text, (uint)text.Length, format, ref rect, brush, options, measuringMode);
        }

        public static void DrawBitmap(this IComObject<ID2D1RenderTarget> device,
            IComObject<ID2D1Bitmap1> bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null) => DrawBitmap(device?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle);

        public static void DrawBitmap(this IComObject<ID2D1RenderTarget> device,
            IComObject<ID2D1Bitmap> bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null) => DrawBitmap(device?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle);

        public static void DrawBitmap(this ID2D1RenderTarget device,
            ID2D1Bitmap bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var drc = destinationRectangle.StructureToMemory())
            {
                using (var src = sourceRectangle.StructureToMemory())
                {
                    device.DrawBitmap(bitmap, drc.Pointer, opacity, interpolationMode, src.Pointer);
                }
            }
        }
    }
}