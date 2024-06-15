using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class ID2D1RenderTargetExtensions
    {
        public static D2D1_WINDOW_STATE CheckWindowState(this IComObject<ID2D1HwndRenderTarget> renderTarget) => CheckWindowState(renderTarget?.Object);
        public static D2D1_WINDOW_STATE CheckWindowState(this ID2D1HwndRenderTarget renderTarget)
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            return renderTarget.CheckWindowState();
        }

        public static IntPtr GetHwnd(this IComObject<ID2D1HwndRenderTarget> renderTarget) => GetHwnd(renderTarget?.Object);
        public static IntPtr GetHwnd(this ID2D1HwndRenderTarget renderTarget)
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            return renderTarget.GetHwnd();
        }

        public static void Resize(this IComObject<ID2D1HwndRenderTarget> renderTarget, D2D_SIZE_U size) => Resize(renderTarget?.Object, size);
        public static void Resize(this ID2D1HwndRenderTarget renderTarget, D2D_SIZE_U size)
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            renderTarget.Resize(ref size).ThrowOnError();
        }

        public static IComObject<ID2D1Bitmap> GetBitmap(this IComObject<ID2D1BitmapRenderTarget> renderTarget) => GetBitmap<ID2D1Bitmap>(renderTarget?.Object);
        public static IComObject<T> GetBitmap<T>(this IComObject<ID2D1BitmapRenderTarget> renderTarget) where T : ID2D1Bitmap => GetBitmap<T>(renderTarget?.Object);
        public static IComObject<T> GetBitmap<T>(this ID2D1BitmapRenderTarget renderTarget) where T : ID2D1Bitmap
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            renderTarget.GetBitmap(out var bmp).ThrowOnError();
            return new ComObject<T>((T)bmp);
        }

        public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1RenderTarget> renterTarget, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES properties) => CreateBitmap<ID2D1Bitmap>(renterTarget?.Object, size, IntPtr.Zero, 0, properties);
        public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1RenderTarget> renterTarget, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) => CreateBitmap<ID2D1Bitmap>(renterTarget?.Object, size, srcData, pitch, properties);
        public static IComObject<T> CreateBitmap<T>(this IComObject<ID2D1RenderTarget> renterTarget, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) where T : ID2D1Bitmap => CreateBitmap<T>(renterTarget?.Object, size, srcData, pitch, properties);
        public static IComObject<T> CreateBitmap<T>(this ID2D1RenderTarget renterTarget, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES properties) where T : ID2D1Bitmap
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.CreateBitmap(size, srcData, pitch, ref properties, out var bmp).ThrowOnError();
            return new ComObject<T>((T)bmp);
        }

        public static IComObject<ID2D1BitmapRenderTarget> CreateCompatibleRenderTarget(this IComObject<ID2D1RenderTarget> renterTarget, D2D_SIZE_F? desiredSize = null, D2D_SIZE_U? desiredPixelSize = null, D2D1_PIXEL_FORMAT? desiredFormat = null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options = D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE) => CreateCompatibleRenderTarget(renterTarget?.Object, desiredSize, desiredPixelSize, desiredFormat, options);
        public static IComObject<ID2D1BitmapRenderTarget> CreateCompatibleRenderTarget(this ID2D1RenderTarget renterTarget, D2D_SIZE_F? desiredSize = null, D2D_SIZE_U? desiredPixelSize = null, D2D1_PIXEL_FORMAT? desiredFormat = null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options = D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            using (var desiredSizeMem = new ComMemory(desiredSize))
            {
                using (var desiredPixelSizeMem = new ComMemory(desiredPixelSize))
                {
                    using (var desiredFormatMem = new ComMemory(desiredFormat))
                    {
                        renterTarget.CreateCompatibleRenderTarget(desiredSizeMem.Pointer, desiredPixelSizeMem.Pointer, desiredFormatMem.Pointer, options, out var target).ThrowOnError();
                        return new ComObject<ID2D1BitmapRenderTarget>(target);
                    }
                }
            }
        }

        public static IComObject<ID2D1SolidColorBrush> CreateSolidColorBrush(this IComObject<ID2D1RenderTarget> renterTarget, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) => CreateSolidColorBrush<ID2D1SolidColorBrush>(renterTarget?.Object, color, properties);
        public static IComObject<T> CreateSolidColorBrush<T>(this IComObject<ID2D1RenderTarget> renterTarget, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush => CreateSolidColorBrush<T>(renterTarget?.Object, color, properties);
        public static IComObject<T> CreateSolidColorBrush<T>(this ID2D1RenderTarget renterTarget, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1SolidColorBrush
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (properties.HasValue)
            {
                using (var props = properties.Value.StructureToMemory())
                {
                    renterTarget.CreateSolidColorBrush(ref color, props.Pointer, out var brush).ThrowOnError();
                    return new ComObject<T>((T)brush);
                }
            }

            renterTarget.CreateSolidColorBrush(ref color, IntPtr.Zero, out var brush2).ThrowOnError();
            return new ComObject<T>((T)brush2);
        }


        public static IComObject<ID2D1BitmapBrush> CreateBitmapBrush(this IComObject<ID2D1RenderTarget> renterTarget, IComObject<ID2D1Bitmap> bitmap, D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? properties = null) => CreateBitmapBrush<ID2D1BitmapBrush>(renterTarget?.Object, bitmap?.Object, bitmapBrushProperties, properties);
        public static IComObject<T> CreateBitmapBrush<T>(this IComObject<ID2D1RenderTarget> renterTarget, IComObject<ID2D1Bitmap> bitmap, D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1BitmapBrush => CreateBitmapBrush<T>(renterTarget?.Object, bitmap?.Object, bitmapBrushProperties, properties);
        public static IComObject<T> CreateBitmapBrush<T>(this ID2D1RenderTarget renterTarget, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1BitmapBrush
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            using (var bbMem = new ComMemory(bitmapBrushProperties))
            {
                using (var pMem = new ComMemory(properties))
                {
                    renterTarget.CreateBitmapBrush(bitmap, bbMem.Pointer, pMem.Pointer, out var brush).ThrowOnError();
                    return new ComObject<T>((T)brush);
                }
            }
        }

        public static IComObject<ID2D1RadialGradientBrush> CreateRadialGradientBrush(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, IComObject<ID2D1GradientStopCollection> stops, D2D1_BRUSH_PROPERTIES? brushProperties = null) => CreateRadialGradientBrush(renterTarget?.Object, gradientBrushProperties, stops?.Object, brushProperties);
        public static IComObject<ID2D1RadialGradientBrush> CreateRadialGradientBrush(this ID2D1RenderTarget renterTarget, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, ID2D1GradientStopCollection stops, D2D1_BRUSH_PROPERTIES? brushProperties = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (stops == null)
                throw new ArgumentNullException(nameof(stops));

            using (var props = brushProperties.StructureToMemory())
            {
                renterTarget.CreateRadialGradientBrush(gradientBrushProperties, props.Pointer, stops, out var brush).ThrowOnError();
                return new ComObject<ID2D1RadialGradientBrush>(brush);
            }
        }

        public static IComObject<ID2D1LinearGradientBrush> CreateLinearGradientBrush(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, IComObject<ID2D1GradientStopCollection> stops, D2D1_BRUSH_PROPERTIES? brushProperties = null) => CreateLinearGradientBrush(renterTarget?.Object, gradientBrushProperties, stops?.Object, brushProperties);
        public static IComObject<ID2D1LinearGradientBrush> CreateLinearGradientBrush(this ID2D1RenderTarget renterTarget, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES gradientBrushProperties, ID2D1GradientStopCollection stops, D2D1_BRUSH_PROPERTIES? brushProperties = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (stops == null)
                throw new ArgumentNullException(nameof(stops));

            using (var props = brushProperties.StructureToMemory())
            {
                renterTarget.CreateLinearGradientBrush(gradientBrushProperties, props.Pointer, stops, out var brush).ThrowOnError();
                return new ComObject<ID2D1LinearGradientBrush>(brush);
            }
        }

        public static IComObject<ID2D1GradientStopCollection> CreateGradientStopCollection(this IComObject<ID2D1RenderTarget> renterTarget, IEnumerable<D2D1_GRADIENT_STOP> stops, D2D1_GAMMA gamma = D2D1_GAMMA.D2D1_GAMMA_2_2, D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP) => CreateGradientStopCollection(renterTarget?.Object, stops, gamma, extendMode);
        public static IComObject<ID2D1GradientStopCollection> CreateGradientStopCollection(this ID2D1RenderTarget renterTarget, IEnumerable<D2D1_GRADIENT_STOP> stops, D2D1_GAMMA gamma = D2D1_GAMMA.D2D1_GAMMA_2_2, D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (stops == null)
                throw new ArgumentNullException(nameof(stops));

            var finalStops = stops.ToArray();
            if (finalStops.Length == 0)
                throw new ArgumentException(null, nameof(stops));

            renterTarget.CreateGradientStopCollection(finalStops, finalStops.Length, gamma, extendMode, out var stps).ThrowOnError();
            return new ComObject<ID2D1GradientStopCollection>(stps);
        }

        public static void WithTextAntialiasMode(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_TEXT_ANTIALIAS_MODE mode, Action action) => WithTextAntialiasMode(renterTarget?.Object, mode, action);
        public static void WithTextAntialiasMode(this ID2D1RenderTarget renterTarget, D2D1_TEXT_ANTIALIAS_MODE mode, Action action)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var old = renterTarget.GetTextAntialiasMode();
            try
            {
                renterTarget.SetTextAntialiasMode(mode);
                action();
            }
            finally
            {
                renterTarget.SetTextAntialiasMode(old);
            }
        }

        public static void WithAntialiasMode(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_ANTIALIAS_MODE mode, Action action) => WithAntialiasMode(renterTarget?.Object, mode, action);
        public static void WithAntialiasMode(this ID2D1RenderTarget renterTarget, D2D1_ANTIALIAS_MODE mode, Action action)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var old = renterTarget.GetAntialiasMode();
            try
            {
                renterTarget.SetAntialiasMode(mode);
                action();
            }
            finally
            {
                renterTarget.SetAntialiasMode(old);
            }
        }

        public static D2D_SIZE_U GetPixelSize(this IComObject<ID2D1RenderTarget> renterTarget) => GetPixelSize(renterTarget?.Object);
        public static D2D_SIZE_U GetPixelSize(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.GetPixelSize(out var size);
            return size;
        }

        public static D2D_SIZE_F GetSize(this IComObject<ID2D1RenderTarget> renterTarget) => GetSize(renterTarget?.Object);
        public static D2D_SIZE_F GetSize(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.GetSize(out var size);
            return size;
        }

        public static D2D1_PIXEL_FORMAT GetPixelFormat(this IComObject<ID2D1RenderTarget> renterTarget) => GetPixelFormat(renterTarget?.Object);
        public static D2D1_PIXEL_FORMAT GetPixelFormat(this ID2D1RenderTarget context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetPixelFormat(out var format);
            return format;
        }

        public static void SetTags(this IComObject<ID2D1RenderTarget> renterTarget, ulong tag1, ulong tag2 = 0) => SetTags(renterTarget?.Object, tag1, tag2);
        public static void SetTags(this ID2D1RenderTarget renterTarget, ulong tag1, ulong tag2 = 0)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.SetTags(tag1, tag2);
        }

        // this one is useless but is consistent with EndDraw
        public static void BeginDraw(this IComObject<ID2D1RenderTarget> renterTarget) => BeginDraw(renterTarget?.Object);
        public static void BeginDraw(this ID2D1RenderTarget renterTarget) => renterTarget?.BeginDraw();
        public static void EndDraw(this IComObject<ID2D1RenderTarget> renterTarget) => EndDraw(renterTarget?.Object);
        public static void EndDraw(this ID2D1RenderTarget renterTarget) => renterTarget?.EndDraw(IntPtr.Zero, IntPtr.Zero).ThrowOnError();
        public static void Clear(this IComObject<ID2D1RenderTarget> renterTarget, _D3DCOLORVALUE? clearColor = null) => Clear(renterTarget?.Object, clearColor);
        public static void Clear(this ID2D1RenderTarget renterTarget, _D3DCOLORVALUE? clearColor = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (clearColor.HasValue)
            {
                using (var cc = clearColor.Value.StructureToMemory())
                {
                    renterTarget.Clear(cc.Pointer);
                }
                return;
            }
            renterTarget.Clear(IntPtr.Zero);
        }

        public static void DrawText(this IComObject<ID2D1RenderTarget> renterTarget,
            string text,
            IComObject<IDWriteTextFormat> format,
            D2D_RECT_F rect,
            IComObject<ID2D1Brush> brush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL) => DrawText(renterTarget?.Object, text, format?.Object, rect, brush?.Object, options, measuringMode);

        public static void DrawText(this ID2D1RenderTarget renterTarget,
            string text,
            IDWriteTextFormat format,
            D2D_RECT_F rect,
            ID2D1Brush brush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (format == null)
                throw new ArgumentNullException(nameof(format));

            if (text == null)
                return;

            renterTarget.DrawTextW(text, (uint)text.Length, format, ref rect, brush, options, measuringMode);
        }

        public static void DrawBitmap(this IComObject<ID2D1RenderTarget> renterTarget,
            IComObject<ID2D1Bitmap1> bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null) => DrawBitmap(renterTarget?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle);

        public static void DrawBitmap(this IComObject<ID2D1RenderTarget> renterTarget,
            IComObject<ID2D1Bitmap> bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null) => DrawBitmap(renterTarget?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle);

        public static void DrawBitmap(this ID2D1RenderTarget renterTarget,
            ID2D1Bitmap bitmap,
            float opacity,
            D2D1_BITMAP_INTERPOLATION_MODE interpolationMode,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            using (var drc = destinationRectangle.StructureToMemory())
            {
                using (var src = sourceRectangle.StructureToMemory())
                {
                    renterTarget.DrawBitmap(bitmap, drc.Pointer, opacity, interpolationMode, src.Pointer);
                }
            }
        }

        public static void DrawTextLayout(this IComObject<ID2D1RenderTarget> renterTarget,
            D2D_POINT_2F origin,
            IComObject<IDWriteTextLayout> layout,
            IComObject<ID2D1Brush> defaultFillBrush = null,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => DrawTextLayout(renterTarget?.Object, origin, layout?.Object, defaultFillBrush?.Object, options);

        public static void DrawTextLayout(this ID2D1RenderTarget renterTarget,
            D2D_POINT_2F origin,
            IDWriteTextLayout layout,
            ID2D1Brush defaultFillBrush = null,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (layout == null)
                throw new ArgumentNullException(nameof(layout));

            renterTarget.DrawTextLayout(origin, layout, defaultFillBrush, options);
        }

        public static void FillGeometry(this IComObject<ID2D1RenderTarget> renterTarget, IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Brush> brush, IComObject<ID2D1Brush> opacityBrush = null) => FillGeometry(renterTarget?.Object, geometry?.Object, brush?.Object, opacityBrush?.Object);
        public static void FillGeometry(this ID2D1RenderTarget renterTarget, ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush opacityBrush = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            renterTarget.FillGeometry(geometry, brush, opacityBrush);
        }

        public static void DrawLine(this IComObject<ID2D1RenderTarget> renterTarget, D2D_POINT_2F point0, D2D_POINT_2F point1, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle> strokeStyle = null) => DrawLine(renterTarget?.Object, point0, point1, brush?.Object, strokeWidth, strokeStyle?.Object);
        public static void DrawLine(this ID2D1RenderTarget renterTarget, D2D_POINT_2F point0, D2D_POINT_2F point1, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle strokeStyle = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            renterTarget.DrawLine(point0, point1, brush, strokeWidth, strokeStyle);
        }

        public static void DrawRoundedRectangle(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_ROUNDED_RECT roundedRect, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle> strokeStyle = null) => DrawRoundedRectangle(renterTarget?.Object, roundedRect, brush?.Object, strokeWidth, strokeStyle?.Object);
        public static void DrawRoundedRectangle(this ID2D1RenderTarget renterTarget, D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle strokeStyle = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            renterTarget.DrawRoundedRectangle(ref roundedRect, brush, strokeWidth, strokeStyle);
        }

        public static void FillRoundedRectangle(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_ROUNDED_RECT roundedRect, IComObject<ID2D1Brush> brush) => FillRoundedRectangle(renterTarget?.Object, roundedRect, brush?.Object);
        public static void FillRoundedRectangle(this ID2D1RenderTarget renterTarget, D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            renterTarget.FillRoundedRectangle(ref roundedRect, brush);
        }

        public static void DrawRectangle(this IComObject<ID2D1RenderTarget> renterTarget, D2D_RECT_F rect, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle> strokeStyle = null) => DrawRectangle(renterTarget?.Object, rect, brush?.Object, strokeWidth, strokeStyle?.Object);
        public static void DrawRectangle(this ID2D1RenderTarget renterTarget, D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle strokeStyle = null)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            renterTarget.DrawRectangle(ref rect, brush, strokeWidth, strokeStyle);
        }

        public static void FillRectangle(this IComObject<ID2D1RenderTarget> renterTarget, D2D_RECT_F rect, IComObject<ID2D1Brush> brush) => FillRectangle(renterTarget?.Object, rect, brush?.Object);
        public static void FillRectangle(this ID2D1RenderTarget context, D2D_RECT_F rect, ID2D1Brush brush)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            context.FillRectangle(ref rect, brush);
        }

        public static void DrawEllipse(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_ELLIPSE ellipse, IComObject<ID2D1Brush> brush, float strokeWidth = 1, IComObject<ID2D1StrokeStyle> strokeStyle = null) => DrawEllipse(renterTarget?.Object, ellipse, brush?.Object, strokeWidth, strokeStyle?.Object);
        public static void DrawEllipse(this ID2D1RenderTarget context, D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth = 1, ID2D1StrokeStyle strokeStyle = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            context.DrawEllipse(ref ellipse, brush, strokeWidth, strokeStyle);
        }

        public static void FillEllipse(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_ELLIPSE ellipse, IComObject<ID2D1Brush> brush) => FillEllipse(renterTarget?.Object, ellipse, brush?.Object);
        public static void FillEllipse(this ID2D1RenderTarget context, D2D1_ELLIPSE ellipse, ID2D1Brush brush)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            context.FillEllipse(ref ellipse, brush);
        }

        public static void DrawGeometry(this IComObject<ID2D1RenderTarget> renderTarget,
            IComObject<ID2D1Geometry> geometry,
            IComObject<ID2D1Brush> brush,
            float strokeWidth = 1,
            IComObject<ID2D1StrokeStyle> strokeStyle = null) => DrawGeometry(renderTarget?.Object, geometry?.Object, brush?.Object, strokeWidth, strokeStyle?.Object);

        public static void DrawGeometry(this ID2D1RenderTarget renderTarget,
            ID2D1Geometry geometry,
            ID2D1Brush brush,
            float strokeWidth = 1,
            ID2D1StrokeStyle strokeStyle = null)
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            if (brush == null)
                throw new ArgumentNullException(nameof(brush));

            renderTarget.DrawGeometry(geometry, brush, strokeWidth, strokeStyle);
        }

        public static void PushLayer(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_LAYER_PARAMETERS parameters) => PushLayer(renterTarget?.Object, parameters);
        public static void PushLayer(this ID2D1RenderTarget context, D2D1_LAYER_PARAMETERS parameters)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.PushLayer(ref parameters, null);
        }

        public static void PopLayer(this IComObject<ID2D1RenderTarget> renterTarget) => PopLayer(renterTarget?.Object);
        public static void PopLayer(this ID2D1RenderTarget context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.PopLayer();
        }

        public static void PushAxisAlignedClip(this IComObject<ID2D1RenderTarget> renderTarget, D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE.D2D1_ANTIALIAS_MODE_PER_PRIMITIVE) => PushAxisAlignedClip(renderTarget?.Object, clipRect, antialiasMode);
        public static void PushAxisAlignedClip(this ID2D1RenderTarget renderTarget, D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode = D2D1_ANTIALIAS_MODE.D2D1_ANTIALIAS_MODE_PER_PRIMITIVE)
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            renderTarget.PushAxisAlignedClip(ref clipRect, antialiasMode);
        }

        public static void PopAxisAlignedClip(this IComObject<ID2D1RenderTarget> renderTarget) => PopAxisAlignedClip(renderTarget?.Object);
        public static void PopAxisAlignedClip(this ID2D1RenderTarget renderTarget)
        {
            if (renderTarget == null)
                throw new ArgumentNullException(nameof(renderTarget));

            renderTarget.PopAxisAlignedClip();
        }

        public static D2D_SIZE_F GetDpi(this IComObject<ID2D1RenderTarget> renterTarget) => GetDpi(renterTarget?.Object);
        public static D2D_SIZE_F GetDpi(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.GetDpi(out var x, out var y);
            return new D2D_SIZE_F(x, y);
        }

        public static D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode(this IComObject<ID2D1RenderTarget> renterTarget) => GetTextAntialiasMode(renterTarget?.Object);
        public static D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            return renterTarget.GetTextAntialiasMode();
        }

        public static void SetTextAntialiasMode(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_TEXT_ANTIALIAS_MODE mode) => SetTextAntialiasMode(renterTarget?.Object, mode);
        public static void SetTextAntialiasMode(this ID2D1RenderTarget renterTarget, D2D1_TEXT_ANTIALIAS_MODE mode)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.SetTextAntialiasMode(mode);
        }

        public static D2D_MATRIX_3X2_F GetTransform(this IComObject<ID2D1RenderTarget> renterTarget) => GetTransform(renterTarget?.Object);
        public static D2D_MATRIX_3X2_F GetTransform(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.GetTransform(out var transform);
            return transform;
        }

        public static void SetTransform(this IComObject<ID2D1RenderTarget> renterTarget, D2D_MATRIX_3X2_F transform) => SetTransform(renterTarget?.Object, transform);
        public static void SetTransform(this ID2D1RenderTarget renterTarget, D2D_MATRIX_3X2_F transform)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.SetTransform(transform);
        }

        public static D2D1_ANTIALIAS_MODE GetAntialiasMode(this IComObject<ID2D1RenderTarget> renterTarget) => GetAntialiasMode(renterTarget?.Object);
        public static D2D1_ANTIALIAS_MODE GetAntialiasMode(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            return renterTarget.GetAntialiasMode();
        }

        public static void SetAntialiasMode(this IComObject<ID2D1RenderTarget> renterTarget, D2D1_ANTIALIAS_MODE mode) => SetAntialiasMode(renterTarget?.Object, mode);
        public static void SetAntialiasMode(this ID2D1RenderTarget renterTarget, D2D1_ANTIALIAS_MODE mode)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.SetAntialiasMode(mode);
        }

        public static void SetDpi(this IComObject<ID2D1RenderTarget> renterTarget, float dpi) => SetDpi(renterTarget?.Object, dpi, dpi);
        public static void SetDpi(this IComObject<ID2D1RenderTarget> renterTarget, float dpiX, float dpiY) => SetDpi(renterTarget?.Object, dpiX, dpiY);
        public static void SetDpi(this ID2D1RenderTarget renterTarget, float dpi) => SetDpi(renterTarget, dpi, dpi);
        public static void SetDpi(this ID2D1RenderTarget renterTarget, float dpiX, float dpiY)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.SetDpi(dpiX, dpiY);
        }

        public static void SaveDrawingState(this IComObject<ID2D1RenderTarget> renterTarget, IComObject<ID2D1DrawingStateBlock> block) => SaveDrawingState(renterTarget?.Object, block?.Object);
        public static void SaveDrawingState(this ID2D1RenderTarget renterTarget, ID2D1DrawingStateBlock block)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            if (block == null)
                throw new ArgumentNullException(nameof(block));

            renterTarget.SaveDrawingState(block);
        }

        public static void SetTextRenderingParams(this IComObject<ID2D1RenderTarget> renterTarget, IComObject<IDWriteRenderingParams> @params) => SetTextRenderingParams(renterTarget?.Object, @params?.Object);
        public static void SetTextRenderingParams(this ID2D1RenderTarget renterTarget, IDWriteRenderingParams @params)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.SetTextRenderingParams(@params);
        }

        public static IComObject<IDWriteRenderingParams> GetTextRenderingParams(this IComObject<ID2D1RenderTarget> renterTarget) => GetTextRenderingParams(renterTarget?.Object);
        public static IComObject<IDWriteRenderingParams> GetTextRenderingParams(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.GetTextRenderingParams(out var @params);
            if (@params != null)
                return new ComObject<IDWriteRenderingParams>(@params);

            return null;
        }

        public static uint GetMaximumBitmapSize(this IComObject<ID2D1RenderTarget> renterTarget) => GetMaximumBitmapSize(renterTarget?.Object);
        public static uint GetMaximumBitmapSize(this ID2D1RenderTarget renterTarget)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            return renterTarget.GetMaximumBitmapSize();
        }

        public static void Flush(this IComObject<ID2D1RenderTarget> renterTarget) => Flush(renterTarget?.Object, IntPtr.Zero, IntPtr.Zero);
        public static void Flush(this IComObject<ID2D1RenderTarget> renterTarget, IntPtr tag1, IntPtr tag2) => Flush(renterTarget?.Object, tag1, tag2);
        public static void Flush(this ID2D1RenderTarget renterTarget) => Flush(renterTarget, IntPtr.Zero, IntPtr.Zero);
        public static void Flush(this ID2D1RenderTarget renterTarget, IntPtr tag1, IntPtr tag2)
        {
            if (renterTarget == null)
                throw new ArgumentNullException(nameof(renterTarget));

            renterTarget.Flush(tag1, tag2).ThrowOnError();
        }
    }
}