using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class ID2D1GeometrySinkExtensions
    {
        public static void AddArc(this IComObject<ID2D1GeometrySink> sink, D2D_POINT_2F endPoint, D2D_SIZE_F radiusSize, float rotationAngle = 0, D2D1_SWEEP_DIRECTION sweepDirection = D2D1_SWEEP_DIRECTION.D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE, D2D1_ARC_SIZE arcSize = D2D1_ARC_SIZE.D2D1_ARC_SIZE_SMALL) => AddArc(sink?.Object, endPoint, radiusSize, rotationAngle, sweepDirection, arcSize);
        public static void AddArc(this ID2D1GeometrySink sink, D2D_POINT_2F endPoint, D2D_SIZE_F radiusSize, float rotationAngle = 0, D2D1_SWEEP_DIRECTION sweepDirection = D2D1_SWEEP_DIRECTION.D2D1_SWEEP_DIRECTION_COUNTER_CLOCKWISE, D2D1_ARC_SIZE arcSize = D2D1_ARC_SIZE.D2D1_ARC_SIZE_SMALL)
        {
            if (sink == null)
                throw new ArgumentNullException(nameof(sink));

            var seg = new D2D1_ARC_SEGMENT();
            seg.point = endPoint;
            seg.size = radiusSize;
            seg.rotationAngle = rotationAngle;
            seg.sweepDirection = sweepDirection;
            seg.arcSize = arcSize;
            sink.AddArc(ref seg);
        }

        public static void AddQuadraticBeziers(this IComObject<ID2D1GeometrySink> sink, params D2D1_QUADRATIC_BEZIER_SEGMENT[] segments) => AddQuadraticBeziers(sink?.Object, segments);
        public static void AddQuadraticBeziers(this IComObject<ID2D1GeometrySink> sink, IEnumerable<D2D1_QUADRATIC_BEZIER_SEGMENT> segments) => AddQuadraticBeziers(sink?.Object, segments);
        public static void AddQuadraticBeziers(this ID2D1GeometrySink sink, IEnumerable<D2D1_QUADRATIC_BEZIER_SEGMENT> segments)
        {
            if (sink == null)
                throw new ArgumentNullException(nameof(sink));

            if (segments == null)
                throw new ArgumentNullException(nameof(segments));

            var array = segments.ToArray();
            if (array.Length == 0)
                throw new ArgumentException(null, nameof(segments));

            sink.AddQuadraticBeziers(array, array.Length);
        }

        public static void AddQuadraticBezier(this IComObject<ID2D1GeometrySink> sink, D2D1_QUADRATIC_BEZIER_SEGMENT segment) => AddQuadraticBezier(sink?.Object, segment);
        public static void AddQuadraticBezier(this ID2D1GeometrySink sink, D2D1_QUADRATIC_BEZIER_SEGMENT segment)
        {
            if (sink == null)
                throw new ArgumentNullException(nameof(sink));

            sink.AddQuadraticBezier(ref segment);
        }
    }
}
