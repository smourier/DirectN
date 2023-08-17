using System;

namespace DirectN
{
    public static class ID2D1PathGeometryExtensions
    {
        public static IComObject<ID2D1SimplifiedGeometrySink> Open(this IComObject<ID2D1PathGeometry> geometry) => Open<ID2D1SimplifiedGeometrySink>(geometry?.Object);
        public static IComObject<T> Open<T>(this IComObject<ID2D1PathGeometry> geometry) where T : ID2D1SimplifiedGeometrySink => Open<T>(geometry?.Object);
        public static IComObject<T> Open<T>(this ID2D1PathGeometry geometry) where T : ID2D1SimplifiedGeometrySink
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            geometry.Open(out var sink).ThrowOnError();
            return new ComObject<T>((T)sink);
        }

        public static void Stream(this IComObject<ID2D1PathGeometry> geometry, IComObject<ID2D1GeometrySink> geometrySink) => Stream(geometry?.Object, geometrySink?.Object);
        public static void Stream(this ID2D1PathGeometry geometry, ID2D1GeometrySink geometrySink)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (geometrySink == null)
                throw new ArgumentNullException(nameof(geometrySink));

            geometry.Stream(geometrySink).ThrowOnError();
        }

        public static uint GetSegmentCount(this IComObject<ID2D1PathGeometry> geometry) => GetSegmentCount(geometry?.Object);
        public static uint GetSegmentCount(this ID2D1PathGeometry geometry)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            geometry.GetSegmentCount(out var count).ThrowOnError();
            return count;
        }

        public static uint GetFigureCount(this IComObject<ID2D1PathGeometry> geometry) => GetFigureCount(geometry?.Object);
        public static uint GetFigureCount(this ID2D1PathGeometry geometry)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            geometry.GetFigureCount(out var count).ThrowOnError();
            return count;
        }

        public static D2D1_POINT_DESCRIPTION ComputePointAndSegmentAtLength(this IComObject<ID2D1PathGeometry1> geometry, float length, uint startSegment, float flatteningTolerance, D2D_MATRIX_3X2_F? worldTransform = null) => ComputePointAndSegmentAtLength(geometry?.Object, length, startSegment, flatteningTolerance, worldTransform);
        public static D2D1_POINT_DESCRIPTION ComputePointAndSegmentAtLength(this ID2D1PathGeometry1 geometry, float length, uint startSegment, float flatteningTolerance, D2D_MATRIX_3X2_F? worldTransform = null)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            using (var mem = new ComMemory(worldTransform))
            {
                geometry.ComputePointAndSegmentAtLength(length, startSegment, mem.Pointer, flatteningTolerance, out var desc).ThrowOnError();
                return desc;
            }
        }
    }
}
