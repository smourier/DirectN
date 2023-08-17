using System;

namespace DirectN
{
    public static class ID2D1GeometryExtensions
    {
        public const float D2D1_DEFAULT_FLATTENING_TOLERANCE = 0.25f;

        public static D2D_RECT_F GetBounds(this IComObject<ID2D1Geometry> geometry) => GetBounds(geometry?.Object);
        public static D2D_RECT_F GetBounds(this ID2D1Geometry geometry, D2D_MATRIX_3X2_F? worldTransform = null)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            D2D_RECT_F bounds;
            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.GetBounds(mem.Pointer, out bounds).ThrowOnError();
                }
            }
            else
            {
                geometry.GetBounds(IntPtr.Zero, out bounds).ThrowOnError();
            }
            return bounds;
        }

        public static D2D_RECT_F GetWidenedBounds(this IComObject<ID2D1Geometry> geometry, float strokeWidth, IComObject<ID2D1StrokeStyle> strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => GetWidenedBounds(geometry?.Object, strokeWidth, strokeStyle?.Object, worldTransform, flatteningTolerance);
        public static D2D_RECT_F GetWidenedBounds(this ID2D1Geometry geometry, float strokeWidth, ID2D1StrokeStyle strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            D2D_RECT_F bounds;
            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.GetWidenedBounds(strokeWidth, strokeStyle, mem.Pointer, flatteningTolerance, out bounds).ThrowOnError();
                }
            }
            else
            {
                geometry.GetWidenedBounds(strokeWidth, strokeStyle, IntPtr.Zero, flatteningTolerance, out bounds).ThrowOnError();
            }
            return bounds;
        }

        public static bool StrokeContainsPoint(this IComObject<ID2D1Geometry> geometry, D2D_POINT_2F point, float strokeWidth, IComObject<ID2D1StrokeStyle> strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => StrokeContainsPoint(geometry?.Object, point, strokeWidth, strokeStyle?.Object, worldTransform, flatteningTolerance);
        public static bool StrokeContainsPoint(this ID2D1Geometry geometry, D2D_POINT_2F point, float strokeWidth, ID2D1StrokeStyle strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            bool contains;
            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.StrokeContainsPoint(point, strokeWidth, strokeStyle, mem.Pointer, flatteningTolerance, out contains).ThrowOnError();
                }
            }
            else
            {
                geometry.StrokeContainsPoint(point, strokeWidth, strokeStyle, IntPtr.Zero, flatteningTolerance, out contains).ThrowOnError();
            }
            return contains;
        }

        public static bool FillContainsPoint(this IComObject<ID2D1Geometry> geometry, D2D_POINT_2F point, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => FillContainsPoint(geometry?.Object, point, worldTransform, flatteningTolerance);
        public static bool FillContainsPoint(this ID2D1Geometry geometry, D2D_POINT_2F point, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            bool contains;
            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.FillContainsPoint(point, mem.Pointer, flatteningTolerance, out contains).ThrowOnError();
                }
            }
            else
            {
                geometry.FillContainsPoint(point, IntPtr.Zero, flatteningTolerance, out contains).ThrowOnError();
            }
            return contains;
        }

        public static D2D1_GEOMETRY_RELATION CompareWithGeometry(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Geometry> inputGeometry, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => CompareWithGeometry(geometry?.Object, inputGeometry?.Object, inputGeometryTransform, flatteningTolerance);
        public static D2D1_GEOMETRY_RELATION CompareWithGeometry(this ID2D1Geometry geometry, ID2D1Geometry inputGeometry, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            D2D1_GEOMETRY_RELATION relation;
            if (inputGeometryTransform.HasValue)
            {
                using (var mem = new ComMemory(inputGeometryTransform.Value))
                {
                    geometry.CompareWithGeometry(inputGeometry, mem.Pointer, flatteningTolerance, out relation).ThrowOnError();
                }
            }
            else
            {
                geometry.CompareWithGeometry(inputGeometry, IntPtr.Zero, flatteningTolerance, out relation).ThrowOnError();
            }
            return relation;
        }

        public static void Simplify(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption = D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => Simplify(geometry?.Object, geometrySink?.Object, simplificationOption, worldTransform, flatteningTolerance);
        public static void Simplify(this ID2D1Geometry geometry, ID2D1SimplifiedGeometrySink geometrySink, D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption = D2D1_GEOMETRY_SIMPLIFICATION_OPTION.D2D1_GEOMETRY_SIMPLIFICATION_OPTION_CUBICS_AND_LINES, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (geometrySink == null)
                throw new ArgumentNullException(nameof(geometrySink));

            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.Simplify(simplificationOption, mem.Pointer, flatteningTolerance, geometrySink).ThrowOnError();
                }
            }
            else
            {
                geometry.Simplify(simplificationOption, IntPtr.Zero, flatteningTolerance, geometrySink).ThrowOnError();
            }
        }

        public static void Tessellate(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1TessellationSink> tessellationSink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => Tessellate(geometry?.Object, tessellationSink?.Object, worldTransform, flatteningTolerance);
        public static void Tessellate(this ID2D1Geometry geometry, ID2D1TessellationSink tessellationSink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (tessellationSink == null)
                throw new ArgumentNullException(nameof(tessellationSink));

            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.Tessellate(mem.Pointer, flatteningTolerance, tessellationSink).ThrowOnError();
                }
            }
            else
            {
                geometry.Tessellate(IntPtr.Zero, flatteningTolerance, tessellationSink).ThrowOnError();
            }
        }

        public static void CombineWithGeometry(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1Geometry> inputGeometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, D2D1_COMBINE_MODE combineMode = D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_UNION, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => CombineWithGeometry(geometry?.Object, inputGeometry?.Object, geometrySink?.Object, combineMode, inputGeometryTransform, flatteningTolerance);
        public static void CombineWithGeometry(this ID2D1Geometry geometry, ID2D1Geometry inputGeometry, ID2D1SimplifiedGeometrySink geometrySink, D2D1_COMBINE_MODE combineMode = D2D1_COMBINE_MODE.D2D1_COMBINE_MODE_UNION, D2D_MATRIX_3X2_F? inputGeometryTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (inputGeometry == null)
                throw new ArgumentNullException(nameof(inputGeometry));

            if (geometrySink == null)
                throw new ArgumentNullException(nameof(geometrySink));

            if (inputGeometryTransform.HasValue)
            {
                using (var mem = new ComMemory(inputGeometryTransform.Value))
                {
                    geometry.CombineWithGeometry(inputGeometry, combineMode, mem.Pointer, flatteningTolerance, geometrySink).ThrowOnError();
                }
            }
            else
            {
                geometry.CombineWithGeometry(inputGeometry, combineMode, IntPtr.Zero, flatteningTolerance, geometrySink).ThrowOnError();
            }
        }

        public static void Outline(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => Outline(geometry?.Object, geometrySink?.Object, worldTransform, flatteningTolerance);
        public static void Outline(this ID2D1Geometry geometry, ID2D1SimplifiedGeometrySink geometrySink, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (geometrySink == null)
                throw new ArgumentNullException(nameof(geometrySink));

            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.Outline(mem.Pointer, flatteningTolerance, geometrySink).ThrowOnError();
                }
            }
            else
            {
                geometry.Outline(IntPtr.Zero, flatteningTolerance, geometrySink).ThrowOnError();
            }
        }

        public static D2D_RECT_F ComputeArea(this IComObject<ID2D1Geometry> geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => ComputeArea(geometry?.Object, worldTransform, flatteningTolerance);
        public static D2D_RECT_F ComputeArea(this ID2D1Geometry geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            float area;
            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.ComputeArea(mem.Pointer, flatteningTolerance, out area).ThrowOnError();
                }
            }
            else
            {
                geometry.ComputeArea(IntPtr.Zero, flatteningTolerance, out area).ThrowOnError();
            }
            return area;
        }

        public static D2D_RECT_F ComputeLength(this IComObject<ID2D1Geometry> geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => ComputeLength(geometry?.Object, worldTransform, flatteningTolerance);
        public static D2D_RECT_F ComputeLength(this ID2D1Geometry geometry, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            float area;
            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.ComputeLength(mem.Pointer, flatteningTolerance, out area).ThrowOnError();
                }
            }
            else
            {
                geometry.ComputeLength(IntPtr.Zero, flatteningTolerance, out area).ThrowOnError();
            }
            return area;
        }

        public static Tuple<D2D_POINT_2F, D2D_POINT_2F> ComputePointAtLength(this IComObject<ID2D1Geometry> geometry, float length, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => ComputePointAtLength(geometry?.Object, length, worldTransform, flatteningTolerance);
        public static Tuple<D2D_POINT_2F, D2D_POINT_2F> ComputePointAtLength(this ID2D1Geometry geometry, float length, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            var point = new D2D_POINT_2F();
            var unitTangentVector = new D2D_POINT_2F();
            using (var pointMem = new ComMemory(point))
            using (var unitTangentVectorMem = new ComMemory(unitTangentVector))
            {
                if (worldTransform.HasValue)
                {
                    using (var mem = new ComMemory(worldTransform.Value))
                    {
                        geometry.ComputePointAtLength(length, mem.Pointer, flatteningTolerance, pointMem.Pointer, unitTangentVectorMem.Pointer).ThrowOnError();
                    }
                }
                else
                {
                    geometry.ComputePointAtLength(length, IntPtr.Zero, flatteningTolerance, pointMem.Pointer, unitTangentVectorMem.Pointer).ThrowOnError();
                }

                return new Tuple<D2D_POINT_2F, D2D_POINT_2F>(pointMem.ToStructure<D2D_POINT_2F>(), unitTangentVectorMem.ToStructure<D2D_POINT_2F>());
            }
        }

        public static void Widen(this IComObject<ID2D1Geometry> geometry, IComObject<ID2D1SimplifiedGeometrySink> geometrySink, float strokeWidth, IComObject<ID2D1StrokeStyle> strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE) => Widen(geometry?.Object, geometrySink?.Object, strokeWidth, strokeStyle?.Object, worldTransform, flatteningTolerance);
        public static void Widen(this ID2D1Geometry geometry, ID2D1SimplifiedGeometrySink geometrySink, float strokeWidth, ID2D1StrokeStyle strokeStyle = null, D2D_MATRIX_3X2_F? worldTransform = null, float flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE)
        {
            if (geometry == null)
                throw new ArgumentNullException(nameof(geometry));

            if (geometrySink == null)
                throw new ArgumentNullException(nameof(geometrySink));

            if (worldTransform.HasValue)
            {
                using (var mem = new ComMemory(worldTransform.Value))
                {
                    geometry.Widen(strokeWidth, strokeStyle, mem.Pointer, flatteningTolerance, geometrySink).ThrowOnError();
                }
            }
            else
            {
                geometry.Widen(strokeWidth, strokeStyle, IntPtr.Zero, flatteningTolerance, geometrySink).ThrowOnError();
            }
        }
    }
}
