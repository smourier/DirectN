using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID2D1DeviceContextExtensions
    {
        public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, D2D1_BITMAP_PROPERTIES1 properties) => CreateBitmap<ID2D1Bitmap>(context?.Object, size, IntPtr.Zero, 0, properties);
        public static IComObject<ID2D1Bitmap> CreateBitmap(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) => CreateBitmap<ID2D1Bitmap>(context?.Object, size, srcData, pitch, properties);
        public static IComObject<T> CreateBitmap<T>(this IComObject<ID2D1DeviceContext> context, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap => CreateBitmap<T>(context?.Object, size, srcData, pitch, properties);
        public static IComObject<T> CreateBitmap<T>(this ID2D1DeviceContext context, D2D_SIZE_U size, IntPtr srcData, uint pitch, D2D1_BITMAP_PROPERTIES1 properties) where T : ID2D1Bitmap
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.CreateBitmap(size, srcData, pitch, ref properties, out var bmp).ThrowOnError();
            return new ComObject<T>((T)bmp);
        }

        public static IComObject<ID2D1Bitmap1> CreateBitmapFromDxgiSurface(this IComObject<ID2D1DeviceContext> context, IComObject<IDXGISurface> surface, D2D1_BITMAP_PROPERTIES1? properties = null) => CreateBitmapFromDxgiSurface<ID2D1Bitmap1>(context?.Object, surface?.Object, properties);
        public static IComObject<T> CreateBitmapFromDxgiSurface<T>(this IComObject<ID2D1DeviceContext> context, IComObject<IDXGISurface> surface, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1 => CreateBitmapFromDxgiSurface<T>(context?.Object, surface?.Object, properties);
        public static IComObject<T> CreateBitmapFromDxgiSurface<T>(this ID2D1DeviceContext context, IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = properties.StructureToMemory())
            {
                context.CreateBitmapFromDxgiSurface(surface, mem.Pointer, out var bmp).ThrowOnError();
                return new ComObject<T>((T)bmp);
            }
        }

        public static IComObject<ID2D1Bitmap1> CreateBitmapFromWicBitmap(this IComObject<ID2D1DeviceContext> context, IComObject<IWICBitmapSource> source, D2D1_BITMAP_PROPERTIES1? properties = null) => CreateBitmapFromWicBitmap<ID2D1Bitmap1>(context?.Object, source?.Object, properties);
        public static IComObject<T> CreateBitmapFromWicBitmap<T>(this IComObject<ID2D1DeviceContext> context, IComObject<IWICBitmapSource> source, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1 => CreateBitmapFromWicBitmap<T>(context?.Object, source?.Object, properties);
        public static IComObject<T> CreateBitmapFromWicBitmap<T>(this ID2D1DeviceContext context, IWICBitmapSource source, D2D1_BITMAP_PROPERTIES1? properties = null) where T : ID2D1Bitmap1
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (source == null)
                throw new ArgumentNullException(nameof(source));

            using (var mem = properties.StructureToMemory())
            {
                context.CreateBitmapFromWicBitmap(source, mem.Pointer, out ID2D1Bitmap1 bmp).ThrowOnError();
                return new ComObject<T>((T)bmp);
            }
        }

        public static IComObject<ID2D1Brush> CreateSolidColorBrush(this IComObject<ID2D1DeviceContext> context, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) => CreateSolidColorBrush<ID2D1Brush>(context?.Object, color, properties);
        public static IComObject<T> CreateSolidColorBrush<T>(this IComObject<ID2D1DeviceContext> context, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1Brush => CreateSolidColorBrush<T>(context?.Object, color, properties);
        public static IComObject<T> CreateSolidColorBrush<T>(this ID2D1DeviceContext context, _D3DCOLORVALUE color, D2D1_BRUSH_PROPERTIES? properties = null) where T : ID2D1Brush
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            using (var props = properties.StructureToMemory())
            {
                context.CreateSolidColorBrush(ref color, props.Pointer, out var brush).ThrowOnError();
                return new ComObject<T>((T)brush);
            }
        }

        public static void WithAntialiasMode(this IComObject<ID2D1DeviceContext> context, D2D1_ANTIALIAS_MODE mode, Action action) => WithAntialiasMode(context?.Object, mode, action);
        public static void WithAntialiasMode(this ID2D1DeviceContext context, D2D1_ANTIALIAS_MODE mode, Action action)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var old = context.GetAntialiasMode();
            try
            {
                context.SetAntialiasMode(mode);
                action();
            }
            finally
            {
                context.SetAntialiasMode(old);
            }
        }

        public static void WithTextAntialiasMode(this IComObject<ID2D1DeviceContext> context, D2D1_TEXT_ANTIALIAS_MODE mode, Action action) => WithTextAntialiasMode(context?.Object, mode, action);
        public static void WithTextAntialiasMode(this ID2D1DeviceContext context, D2D1_TEXT_ANTIALIAS_MODE mode, Action action)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var old = context.GetTextAntialiasMode();
            try
            {
                context.SetTextAntialiasMode(mode);
                action();
            }
            finally
            {
                context.SetTextAntialiasMode(old);
            }
        }

        public static void WithPrimitiveBlend(this IComObject<ID2D1DeviceContext> context, D2D1_PRIMITIVE_BLEND mode, Action action) => WithPrimitiveBlend(context?.Object, mode, action);
        public static void WithPrimitiveBlend(this ID2D1DeviceContext context, D2D1_PRIMITIVE_BLEND mode, Action action)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var old = context.GetPrimitiveBlend();
            try
            {
                context.SetPrimitiveBlend(mode);
                action();
            }
            finally
            {
                context.SetPrimitiveBlend(old);
            }
        }

        public static IComObject<ID2D1Device> GetDevice(this IComObject<ID2D1DeviceContext> context) => GetDevice(context?.Object);
        public static IComObject<ID2D1Device> GetDevice(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetDevice(out var device);
            return device != null ? new ComObject<ID2D1Device>(device) : null;
        }

        public static IComObject<ID2D1Factory> GetFactory(this IComObject<ID2D1DeviceContext> context) => GetFactory(context?.Object);
        public static IComObject<ID2D1Factory> GetFactory(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetFactory(out var factory);
            return factory != null ? new ComObject<ID2D1Factory>(factory) : null;
        }

        //public static void SetTarget(this IComObject<ID2D1DeviceContext> context, ComObject<ID2D1Bitmap1> target) => SetTarget(context?.Object, target?.Object);
        //public static void SetTarget(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Bitmap> target) => SetTarget(context?.Object, target?.Object);
        public static void SetTarget(this IComObject<ID2D1DeviceContext> context, IComObject<ID2D1Image> target) => SetTarget(context?.Object, target?.Object);
        public static void SetTarget(this ID2D1DeviceContext context, ID2D1Image target)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (target == null)
                throw new ArgumentNullException(nameof(context));

            context.SetTarget(target);
        }

        public static IComObject<ID2D1Image> GetTarget(this IComObject<ID2D1DeviceContext> context) => GetTarget(context?.Object);
        public static IComObject<ID2D1Image> GetTarget(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetTarget(out var target);
            return target != null ? new ComObject<ID2D1Image>(target) : null;
        }

        public static D2D_SIZE_U GetPixelSize(this IComObject<ID2D1DeviceContext> context) => GetPixelSize(context?.Object);
        public static D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetPixelSize(out var size);
            return size;
        }

        public static D2D_SIZE_F GetSize(this IComObject<ID2D1DeviceContext> context) => GetSize(context?.Object);
        public static D2D_SIZE_F GetSize(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetSize(out var size);
            return size;
        }

        public static D2D1_PIXEL_FORMAT GetPixelFormat(this IComObject<ID2D1DeviceContext> context) => GetPixelFormat(context?.Object);
        public static D2D1_PIXEL_FORMAT GetPixelFormat(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetPixelFormat(out var format);
            return format;
        }

        public static void SetTags(this IComObject<ID2D1DeviceContext> context, ulong tag1, ulong tag2 = 0) => SetTags(context?.Object, tag1, tag2);
        public static void SetTags(this ID2D1DeviceContext context, ulong tag1, ulong tag2 = 0)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.SetTags(tag1, tag2);
        }

        public static IComObject<ID2D1Effect> CreateEffect(this IComObject<ID2D1DeviceContext> context, Guid id) => CreateEffect(context?.Object, id);
        public static IComObject<ID2D1Effect> CreateEffect(this ID2D1DeviceContext context, Guid id)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.CreateEffect(id, out var effect).ThrowOnError();
            return effect != null ? new ComObject<ID2D1Effect>(effect) : null;
        }

        // this one is useless but is consistent with EndDraw
        public static void BeginDraw(this IComObject<ID2D1DeviceContext> context) => BeginDraw(context?.Object);
        public static void BeginDraw(this ID2D1DeviceContext context) => context?.BeginDraw();
        public static void EndDraw(this IComObject<ID2D1DeviceContext> context) => EndDraw(context?.Object);
        public static void EndDraw(this ID2D1DeviceContext context) => context?.EndDraw(IntPtr.Zero, IntPtr.Zero).ThrowOnError();
        public static void Clear(this IComObject<ID2D1DeviceContext> context) => Clear(context?.Object);
        public static void Clear(this ID2D1DeviceContext context) => context?.Clear(IntPtr.Zero);

        public static void DrawText(this IComObject<ID2D1DeviceContext> context,
            string text,
            IComObject<IDWriteTextFormat> format,
            D2D_RECT_F rect,
            IComObject<ID2D1Brush> defaultFillBrush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL) => DrawText(context?.Object, text, format?.Object, rect, defaultFillBrush?.Object, options, measuringMode);

        public static void DrawText(this ID2D1DeviceContext context,
            string text,
            IDWriteTextFormat format,
            D2D_RECT_F rect,
            ID2D1Brush defaultFillBrush,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE,
            DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE.DWRITE_MEASURING_MODE_NATURAL)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (format == null)
                throw new ArgumentNullException(nameof(format));

            if (defaultFillBrush == null)
                throw new ArgumentNullException(nameof(defaultFillBrush));

            if (text == null)
                return;

            context.DrawTextW(text, (uint)text.Length, format, ref rect, defaultFillBrush, options, measuringMode);
        }

        public static void DrawTextLayout(this IComObject<ID2D1DeviceContext> context,
            D2D_POINT_2F origin,
            IDWriteTextLayout layout,
            ID2D1Brush defaultFillBrush = null,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => DrawTextLayout(context?.Object, origin, layout, defaultFillBrush, options);

        public static void DrawTextLayout(this ID2D1DeviceContext context,
            D2D_POINT_2F origin,
            IDWriteTextLayout layout,
            ID2D1Brush defaultFillBrush = null,
            D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (layout == null)
                throw new ArgumentNullException(nameof(layout));

            context.DrawTextLayout(origin, layout, defaultFillBrush, options);
        }

        public static void DrawBitmap(this IComObject<ID2D1DeviceContext> context,
            IComObject<ID2D1Bitmap1> bitmap,
            float opacity = 1,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null,
            D2D_MATRIX_4X4_F? perspectiveTransform = null) => DrawBitmap(context?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle, perspectiveTransform);

        public static void DrawBitmap(this IComObject<ID2D1DeviceContext> context,
            IComObject<ID2D1Bitmap> bitmap,
            float opacity = 1,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null,
            D2D_MATRIX_4X4_F? perspectiveTransform = null) => DrawBitmap(context?.Object, bitmap?.Object, opacity, interpolationMode, destinationRectangle, sourceRectangle, perspectiveTransform);

        public static void DrawBitmap(this ID2D1DeviceContext context,
            ID2D1Bitmap bitmap,
            float opacity = 1,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_NEAREST_NEIGHBOR,
            D2D_RECT_F? destinationRectangle = null,
            D2D_RECT_F? sourceRectangle = null,
            D2D_MATRIX_4X4_F? perspectiveTransform = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            using (var drc = destinationRectangle.StructureToMemory())
            {
                using (var src = sourceRectangle.StructureToMemory())
                {
                    if (perspectiveTransform.HasValue || (int)interpolationMode > (int)D2D1_BITMAP_INTERPOLATION_MODE.D2D1_BITMAP_INTERPOLATION_MODE_LINEAR)
                    {
                        using (var per = perspectiveTransform.StructureToMemory())
                        {
                            context.DrawBitmap(bitmap, drc.Pointer, opacity, interpolationMode, src.Pointer, per.Pointer);
                        }
                    }
                    else
                    {
                        context.DrawBitmap(bitmap, drc.Pointer, opacity, (D2D1_BITMAP_INTERPOLATION_MODE)interpolationMode, src.Pointer);
                    }
                }
            }
        }

        public static void DrawImage(this IComObject<ID2D1DeviceContext> context,
            IComObject<ID2D1Image> image,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
            D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
            D2D_POINT_2F? targetOffset = null,
            D2D_RECT_F? imageRectangle = null) => DrawImage(context?.Object, image?.Object, interpolationMode, compositeMode, targetOffset, imageRectangle);

        public static void DrawImage(this ID2D1DeviceContext context,
            ID2D1Image image,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
            D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
            D2D_POINT_2F? targetOffset = null,
            D2D_RECT_F? imageRectangle = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (image == null)
                throw new ArgumentNullException(nameof(image));

            using (var irc = imageRectangle.StructureToMemory())
            {
                using (var to = targetOffset.StructureToMemory())
                {
                    context.DrawImage(image, to.Pointer, irc.Pointer, interpolationMode, compositeMode);
                }
            }
        }

        public static void DrawImage(this IComObject<ID2D1DeviceContext> context,
            IComObject<ID2D1Effect> effect,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
            D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
            D2D_POINT_2F? targetOffset = null,
            D2D_RECT_F? imageRectangle = null) => DrawImage(context?.Object, effect?.Object, interpolationMode, compositeMode, targetOffset, imageRectangle);

        public static void DrawImage(this ID2D1DeviceContext context,
            ID2D1Effect effect,
            D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR,
            D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE.D2D1_COMPOSITE_MODE_SOURCE_OVER,
            D2D_POINT_2F? targetOffset = null,
            D2D_RECT_F? imageRectangle = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (effect == null)
                throw new ArgumentNullException(nameof(effect));

            using (var irc = imageRectangle.StructureToMemory())
            {
                using (var to = targetOffset.StructureToMemory())
                {
                    effect.GetOutput(out var image);
                    try
                    {
                        context.DrawImage(image, to.Pointer, irc.Pointer, interpolationMode, compositeMode);
                    }
                    finally
                    {
                        Marshal.ReleaseComObject(image);
                    }
                }
            }
        }

        public static void PushLayer(this IComObject<ID2D1DeviceContext> context, D2D1_LAYER_PARAMETERS1 parameters) => PushLayer(context?.Object, parameters);
        public static void PushLayer(this ID2D1DeviceContext context, D2D1_LAYER_PARAMETERS1 parameters)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.PushLayer(ref parameters, null);
        }

        public static void PopLayer(this IComObject<ID2D1DeviceContext> context) => PopLayer(context?.Object);
        public static void PopLayer(this ID2D1DeviceContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.PopLayer();
        }
    }
}