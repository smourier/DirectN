using System;

namespace DirectN
{
    public static class ID2D1DeviceContextExtensions
    {
        public static ComObject<ID2D1Bitmap> CreateBitmap(this ComObject<ID2D1DeviceContext> device, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES1 properties) => CreateBitmap<ID2D1Bitmap>(device?.Object, size, IntPtr.Zero, 0, properties);
        public static ComObject<ID2D1Bitmap> CreateBitmap(this ComObject<ID2D1DeviceContext> device, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) => CreateBitmap<ID2D1Bitmap>(device?.Object, size, srcData, pitch, properties);
        public static ComObject<T> CreateBitmap<T>(this ComObject<ID2D1DeviceContext> device, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap => CreateBitmap<T>(device?.Object, size, srcData, pitch, properties);
        public static ComObject<T> CreateBitmap<T>(this ID2D1DeviceContext device, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateBitmap(size, srcData, pitch, ref properties, out var bmp).ThrowOnError();
            return new ComObject<T>((T)bmp);
        }

        public static ComObject<ID2D1Bitmap1> CreateBitmapFromDxgiSurface(this ComObject<ID2D1DeviceContext> device, ComObject<IDXGISurface> surface, D2D1_BITMAP_PROPERTIES1? properties = null) => CreateBitmapFromDxgiSurface<ID2D1Bitmap1>(device?.Object, surface?.Object, properties);
        public static ComObject<T> CreateBitmapFromDxgiSurface<T>(this ComObject<ID2D1DeviceContext> device, ComObject<IDXGISurface> surface, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1 => CreateBitmapFromDxgiSurface<T>(device?.Object, surface?.Object, properties);
        public static ComObject<T> CreateBitmapFromDxgiSurface<T>(this ID2D1DeviceContext device, IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = properties.StructureToMemory())
            {
                device.CreateBitmapFromDxgiSurface(surface, mem.Pointer, out var bmp).ThrowOnError();
                return new ComObject<T>((T)bmp);
            }
        }

        public static ComObject<ID2D1SolidColorBrush> CreateSolidColorBrush(this ComObject<ID2D1DeviceContext> device, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) => CreateSolidColorBrush<ID2D1SolidColorBrush>(device?.Object, color, properties);
        public static ComObject<T> CreateSolidColorBrush<T>(this ComObject<ID2D1DeviceContext> device, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush => CreateSolidColorBrush<T>(device?.Object, color, properties);
        public static ComObject<T> CreateSolidColorBrush<T>(this ID2D1DeviceContext device, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var props = properties.StructureToMemory())
            {
                device.CreateSolidColorBrush(ref color, props.Pointer, out var brush).ThrowOnError();
                return new ComObject<T>((T)brush);
            }
        }

        // this one is useless but is consistent with EndDraw
        public static void BeginDraw(this ComObject<ID2D1DeviceContext> device) => BeginDraw(device?.Object);
        public static void BeginDraw(this ID2D1DeviceContext device) => device?.BeginDraw();
        public static void EndDraw(this ComObject<ID2D1DeviceContext> device) => EndDraw(device?.Object);
        public static void EndDraw(this ID2D1DeviceContext device) => device?.EndDraw(out var tag1, out var tag2).ThrowOnError();
        public static void Clear(this ComObject<ID2D1DeviceContext> device) => Clear(device?.Object);
        public static void Clear(this ID2D1DeviceContext device) => device?.Clear(IntPtr.Zero);

        public static void DrawText(this ComObject<ID2D1DeviceContext> device,
            string text,
            ComObject<IDWriteTextFormat> format,
            D2D_RECT_F rect,
            ComObject<ID2D1Brush> brush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL) => DrawText(device?.Object, text, format?.Object, rect, brush?.Object, options, measuringMode);

        public static void DrawText(this ID2D1DeviceContext device,
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

        public static void DrawBitmap(this ComObject<ID2D1DeviceContext> device,
            ComObject<ID2D1Bitmap1> bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null) => DrawBitmap(device?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle);

        public static void DrawBitmap(this ComObject<ID2D1DeviceContext> device,
            ComObject<ID2D1Bitmap> bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null) => DrawBitmap(device?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle);

        public static void DrawBitmap(this ID2D1DeviceContext device,
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