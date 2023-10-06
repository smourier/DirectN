using System;

namespace DirectN
{
    public static class ICompositionDrawingSurfaceInteropExtensions
    {
        public static IComObject<ID2D1DeviceContext> BeginDraw(this IComObject<ICompositionDrawingSurfaceInterop> surface, tagRECT? rect = null) => BeginDraw<ID2D1DeviceContext>(surface?.Object, rect);
        public static IComObject<T> BeginDraw<T>(this IComObject<ICompositionDrawingSurfaceInterop> surface, tagRECT? rect = null) where T : ID2D1DeviceContext => BeginDraw<T>(surface?.Object, rect);
        public static IComObject<T> BeginDraw<T>(this ICompositionDrawingSurfaceInterop surface, tagRECT? rect = null) where T : ID2D1DeviceContext
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            using (var mem = new ComMemory(rect))
            {
                surface.BeginDraw(mem.Pointer, typeof(T).GUID, out var obj, out var offset).ThrowOnError();
                var dc = new ComObject<T>((T)obj);
                if (!offset.IsZero)
                {
                    var tx = D2D_MATRIX_3X2_F.Translation(offset.x, offset.y);
                    dc.Object.SetTransform(ref tx);
                }
                return dc;
            }
        }

        public static void EndDraw(this IComObject<ICompositionDrawingSurfaceInterop> surface) => EndDraw(surface?.Object);
        public static void EndDraw(this ICompositionDrawingSurfaceInterop surface)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            surface.EndDraw().ThrowOnError();
        }
    }
}
