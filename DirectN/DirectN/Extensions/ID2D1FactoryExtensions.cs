using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID2D1FactoryExtensions
    {
        public static IComObject<ID2D1EllipseGeometry> CreateEllipseGeometry(this IComObject<ID2D1Factory1> factory, D2D1_ELLIPSE ellipse) => CreateEllipseGeometry(factory?.Object, ellipse);
        public static IComObject<ID2D1EllipseGeometry> CreateEllipseGeometry(this ID2D1Factory1 factory, D2D1_ELLIPSE ellipse)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateEllipseGeometry(ref ellipse, out var geometry).ThrowOnError();
            return new ComObject<ID2D1EllipseGeometry>(geometry);
        }

        public static IComObject<ID2D1RectangleGeometry> CreateRectangleGeometry(this IComObject<ID2D1Factory1> factory, D2D_RECT_F rectangle) => CreateRectangleGeometry(factory?.Object, rectangle);
        public static IComObject<ID2D1RectangleGeometry> CreateRectangleGeometry(this ID2D1Factory1 factory, D2D_RECT_F rectangle)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateRectangleGeometry(ref rectangle, out var geometry).ThrowOnError();
            return new ComObject<ID2D1RectangleGeometry>(geometry);
        }

        public static IComObject<ID2D1RoundedRectangleGeometry> CreateRoundedRectangleGeometry(this IComObject<ID2D1Factory1> factory, D2D1_ROUNDED_RECT rectangle) => CreateRoundedRectangleGeometry(factory?.Object, rectangle);
        public static IComObject<ID2D1RoundedRectangleGeometry> CreateRoundedRectangleGeometry(this ID2D1Factory1 factory, D2D1_ROUNDED_RECT rectangle)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateRoundedRectangleGeometry(ref rectangle, out var geometry).ThrowOnError();
            return new ComObject<ID2D1RoundedRectangleGeometry>(geometry);
        }

        public static IComObject<ID2D1PathGeometry1> CreatePathGeometry(this IComObject<ID2D1Factory1> factory) => CreatePathGeometry(factory?.Object);
        public static IComObject<ID2D1PathGeometry1> CreatePathGeometry(this ID2D1Factory1 factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreatePathGeometry(out ID2D1PathGeometry1 geometry).ThrowOnError();
            return new ComObject<ID2D1PathGeometry1>(geometry);
        }

        public static IComObject<ID2D1GeometryGroup> CreateGeometryGroup(this IComObject<ID2D1Factory1> factory, D2D1_FILL_MODE fillMode, IReadOnlyList<ID2D1Geometry> geometries) => CreateGeometryGroup(factory?.Object, fillMode, geometries);
        public static IComObject<ID2D1GeometryGroup> CreateGeometryGroup(this ID2D1Factory1 factory, D2D1_FILL_MODE fillMode, IReadOnlyList<ID2D1Geometry> geometries)
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

        public static IComObject<ID2D1DCRenderTarget> CreateDCRenderTarget(this IComObject<ID2D1Factory1> factory, D2D1_RENDER_TARGET_PROPERTIES properties) => CreateDCRenderTarget<ID2D1DCRenderTarget>(factory?.Object, properties);
        public static IComObject<T> CreateDCRenderTarget<T>(this IComObject<ID2D1Factory1> factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget => CreateDCRenderTarget<T>(factory?.Object, properties);
        public static IComObject<T> CreateDCRenderTarget<T>(this ID2D1Factory1 factory, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1DCRenderTarget
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateDCRenderTarget(ref properties, out var target).ThrowOnError();
            return new ComObject<T>((T)target);
        }

        public static IComObject<ID2D1RenderTarget> CreateDxgiSurfaceRenderTarget(this IComObject<ID2D1Factory1> factory, IComObject<IDXGISurface> surface, D2D1_RENDER_TARGET_PROPERTIES properties) => CreateDxgiSurfaceRenderTarget<ID2D1RenderTarget>(factory?.Object, surface?.Object, properties);
        public static IComObject<T> CreateDxgiSurfaceRenderTarget<T>(this IComObject<ID2D1Factory1> factory, IComObject<IDXGISurface> surface, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1RenderTarget => CreateDxgiSurfaceRenderTarget<T>(factory?.Object, surface?.Object, properties);
        public static IComObject<T> CreateDxgiSurfaceRenderTarget<T>(this ID2D1Factory1 factory, IDXGISurface surface, D2D1_RENDER_TARGET_PROPERTIES properties) where T : ID2D1RenderTarget
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            factory.CreateDxgiSurfaceRenderTarget(surface, ref properties, out var target).ThrowOnError();
            return new ComObject<T>((T)target);
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
