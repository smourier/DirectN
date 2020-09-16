using System;

namespace DirectN
{
    public static class ID2D1PathGeometryExtensions
    {
        public static IComObject<ID2D1SimplifiedGeometrySink> Open(this IComObject<ID2D1PathGeometry> geometry) => Open(geometry?.Object);
        public static IComObject<ID2D1SimplifiedGeometrySink> Open(this ID2D1PathGeometry geometry)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            geometry.Open(out var sink).ThrowOnError();
            return new ComObject<ID2D1SimplifiedGeometrySink>(sink);
        }
    }
}
