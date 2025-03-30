using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID2D1FactoryExtensions
    {
        public static IComObject<ID2D1RenderTarget> CreateWicBitmapRenderTarget(this IComObject<ID2D1Factory> factory, IComObject<IWICBitmap> target, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) => CreateWicBitmapRenderTarget<ID2D1RenderTarget>(factory?.Object, target?.Object, renderTargetProperties);
        public static IComObject<T> CreateWicBitmapRenderTarget<T>(this IComObject<ID2D1Factory> factory, IComObject<IWICBitmap> target, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) where T : ID2D1RenderTarget => CreateWicBitmapRenderTarget<T>(factory?.Object, target?.Object, renderTargetProperties);
        public static IComObject<T> CreateWicBitmapRenderTarget<T>(this ID2D1Factory factory, IWICBitmap target, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) where T : ID2D1RenderTarget
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (target == null)
                throw new ArgumentNullException(nameof(target));

            var props = renderTargetProperties ?? new D2D1_RENDER_TARGET_PROPERTIES();
            factory.CreateWicBitmapRenderTarget(target, ref props, out var renderTarget).ThrowOnError();
            return new ComObject<T>((T)renderTarget);
        }

        public static IComObject<ID2D1HwndRenderTarget> CreateHwndRenderTarget(this IComObject<ID2D1Factory> factory, D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null) => CreateHwndRenderTarget(factory?.Object, hwndRenderTargetProperties, renderTargetProperties);
        public static IComObject<ID2D1HwndRenderTarget> CreateHwndRenderTarget(this ID2D1Factory factory, D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, D2D1_RENDER_TARGET_PROPERTIES? renderTargetProperties = null)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            var props = renderTargetProperties ?? new D2D1_RENDER_TARGET_PROPERTIES();
            factory.CreateHwndRenderTarget(ref props, ref hwndRenderTargetProperties, out var renderTarget).ThrowOnError();
            return new ComObject<ID2D1HwndRenderTarget>(renderTarget);
        }

        public static IComObject<ID2D1RenderTarget> CreateDxgiSurfaceRenderTarget(this IComObject<ID2D1Factory> factory, IComObject<IDXGISurface> surface, D2D1_RENDER_TARGET_PROPERTIES? properties = null) => CreateDxgiSurfaceRenderTarget(factory?.Object, surface?.Object, properties);
        public static IComObject<ID2D1RenderTarget> CreateDxgiSurfaceRenderTarget(this ID2D1Factory factory, IDXGISurface surface, D2D1_RENDER_TARGET_PROPERTIES? properties = null)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            var props = properties ?? new D2D1_RENDER_TARGET_PROPERTIES();
            factory.CreateDxgiSurfaceRenderTarget(surface, ref props, out var renderTarget).ThrowOnError();
            return new ComObject<ID2D1RenderTarget>(renderTarget);
        }

        public static IComObject<ID2D1DCRenderTarget> CreateDCRenderTarget(this IComObject<ID2D1Factory> factory, D2D1_RENDER_TARGET_PROPERTIES properties) => CreateDCRenderTarget<ID2D1DCRenderTarget>(factory?.Object, properties);
        public static IComObject<T> CreateDCRenderTarget<T>(this IComObject<ID2D1Factory> factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget => CreateDCRenderTarget<T>(factory?.Object, properties);
        public static IComObject<T> CreateDCRenderTarget<T>(this ID2D1Factory factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateDCRenderTarget(ref properties, out var target).ThrowOnError();
            return new ComObject<T>((T)target);
        }

        public static IComObject<ID2D1StrokeStyle> CreateStrokeStyle(this IComObject<ID2D1Factory> factory, D2D1_STROKE_STYLE_PROPERTIES properties, IEnumerable<float> dashes = null) => CreateStrokeStyle<ID2D1StrokeStyle>(factory?.Object, properties, dashes);
        public static IComObject<T> CreateStrokeStyle<T>(this IComObject<ID2D1Factory> factory, D2D1_STROKE_STYLE_PROPERTIES properties, IEnumerable<float> dashes = null) where T : ID2D1StrokeStyle => CreateStrokeStyle<T>(factory?.Object, properties, dashes);
        public static IComObject<T> CreateStrokeStyle<T>(this ID2D1Factory factory, D2D1_STROKE_STYLE_PROPERTIES properties, IEnumerable<float> dashes = null) where T : ID2D1StrokeStyle
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateStrokeStyle(ref properties, dashes?.ToArray(), (dashes?.Count()).GetValueOrDefault(), out var style).ThrowOnError();
            return new ComObject<T>((T)style);
        }

        public static IComObject<ID2D1EllipseGeometry> CreateEllipseGeometry(this IComObject<ID2D1Factory> factory, D2D1_ELLIPSE ellipse) => CreateEllipseGeometry(factory?.Object, ellipse);
        public static IComObject<ID2D1EllipseGeometry> CreateEllipseGeometry(this ID2D1Factory factory, D2D1_ELLIPSE ellipse)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateEllipseGeometry(ref ellipse, out var geometry).ThrowOnError();
            return new ComObject<ID2D1EllipseGeometry>(geometry);
        }

        public static IComObject<ID2D1RectangleGeometry> CreateRectangleGeometry(this IComObject<ID2D1Factory> factory, D2D_RECT_F rectangle) => CreateRectangleGeometry(factory?.Object, rectangle);
        public static IComObject<ID2D1RectangleGeometry> CreateRectangleGeometry(this ID2D1Factory factory, D2D_RECT_F rectangle)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateRectangleGeometry(ref rectangle, out var geometry).ThrowOnError();
            return new ComObject<ID2D1RectangleGeometry>(geometry);
        }

        public static IComObject<ID2D1RoundedRectangleGeometry> CreateRoundedRectangleGeometry(this IComObject<ID2D1Factory> factory, D2D1_ROUNDED_RECT rectangle) => CreateRoundedRectangleGeometry(factory?.Object, rectangle);
        public static IComObject<ID2D1RoundedRectangleGeometry> CreateRoundedRectangleGeometry(this ID2D1Factory factory, D2D1_ROUNDED_RECT rectangle)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateRoundedRectangleGeometry(ref rectangle, out var geometry).ThrowOnError();
            return new ComObject<ID2D1RoundedRectangleGeometry>(geometry);
        }

        public static IComObject<ID2D1PathGeometry> CreatePathGeometry(this IComObject<ID2D1Factory> factory) => CreatePathGeometry<ID2D1PathGeometry>(factory?.Object);
        public static IComObject<T> CreatePathGeometry<T>(this IComObject<ID2D1Factory> factory) where T : ID2D1PathGeometry => CreatePathGeometry<T>(factory?.Object);
        public static IComObject<T> CreatePathGeometry<T>(this ID2D1Factory factory) where T : ID2D1PathGeometry
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreatePathGeometry(out var geometry).ThrowOnError();
            return new ComObject<T>((T)geometry);
        }

        public static IComObject<ID2D1TransformedGeometry> CreateTransformedGeometry(this IComObject<ID2D1Factory> factory, IComObject<ID2D1Geometry> sourceGeometry, in D2D_MATRIX_3X2_F transform) => CreateTransformedGeometry(factory?.Object, sourceGeometry?.Object, transform);
        public static IComObject<ID2D1TransformedGeometry> CreateTransformedGeometry(this ID2D1Factory factory, ID2D1Geometry sourceGeometry, in D2D_MATRIX_3X2_F transform)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (sourceGeometry == null)
                throw new ArgumentNullException(nameof(sourceGeometry));

            factory.CreateTransformedGeometry(sourceGeometry, transform, out var geometry).ThrowOnError();
            return new ComObject<ID2D1TransformedGeometry>(geometry);
        }

        public static IComObject<ID2D1GeometryGroup> CreateGeometryGroup(this IComObject<ID2D1Factory> factory, D2D1_FILL_MODE fillMode, IReadOnlyList<IComObject<ID2D1Geometry>> geometries) => CreateGeometryGroup(factory?.Object, fillMode, geometries.ToArray());
        public static IComObject<ID2D1GeometryGroup> CreateGeometryGroup(this ID2D1Factory factory, D2D1_FILL_MODE fillMode, IReadOnlyList<ID2D1Geometry> geometries)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (geometries == null)
                throw new ArgumentNullException(nameof(geometries));

            if (geometries.IsEmpty())
                throw new ArgumentException(null, nameof(geometries));

            factory.CreateGeometryGroup(fillMode, geometries.ToArray(), geometries.Count, out var geometry).ThrowOnError();
            return new ComObject<ID2D1GeometryGroup>(geometry);
        }

        public static IComObject<ID2D1Device> CreateDevice(this IComObject<ID2D1Factory1> factory, IComObject<IDXGIDevice> device) => CreateDevice<ID2D1Device>(factory?.Object, device?.Object);
        public static IComObject<T> CreateDevice<T>(this IComObject<ID2D1Factory1> factory, IComObject<IDXGIDevice> device) where T : ID2D1Device => CreateDevice<T>(factory?.Object, device?.Object);
        public static IComObject<T> CreateDevice<T>(this ID2D1Factory1 factory, IDXGIDevice device) where T : ID2D1Device
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            factory.CreateDevice(device, out var dev).ThrowOnError();
            return new ComObject<T>((T)dev);
        }

        public static Guid[] GetRegisteredEffects(this IComObject<ID2D1Factory1> factory) => GetRegisteredEffects(factory?.Object);
        public static Guid[] GetRegisteredEffects(this ID2D1Factory1 factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            var ptr = Marshal.AllocHGlobal(8);
            try
            {
                factory.GetRegisteredEffects(null, 0, ptr, ptr + 4).ThrowOnError();
                var ret = Marshal.ReadInt32(ptr);
                var reg = Marshal.ReadInt32(ptr + 4);

                var clsids = new Guid[reg];
                factory.GetRegisteredEffects(clsids, clsids.Length, ptr, ptr + 4).ThrowOnError();
                return clsids;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}
