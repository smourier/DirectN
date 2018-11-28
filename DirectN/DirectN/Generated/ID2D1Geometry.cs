using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [Guid("2cd906a1-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Geometry
    {
        [PreserveSig]
        HRESULT GetBounds(ref D2D1_MATRIX_3X2_F worldTransform, ref D2D1_RECT_F bounds);

        [PreserveSig]
        HRESULT GetWidenedBounds(float strokeWidth, ID2D1StrokeStyle strokeStyle, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ref D2D1_RECT_F bounds);

        [PreserveSig]
        HRESULT StrokeContainsPoint(D2D1_POINT_2F point, float strokeWidth, ID2D1StrokeStyle strokeStyle, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out bool contains);

        [PreserveSig]
        HRESULT FillContainsPoint(D2D1_POINT_2F point, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out bool contains);

        [PreserveSig]
        HRESULT CompareWithGeometry(ID2D1Geometry inputGeometry, ref D2D1_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, out D2D1_GEOMETRY_RELATION relation);

        [PreserveSig]
        HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        [PreserveSig]
        HRESULT Tessellate(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1TessellationSink tessellationSink);

        [PreserveSig]
        HRESULT CombineWithGeometry(ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, ref D2D1_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        [PreserveSig]
        HRESULT Outline(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);

        [PreserveSig]
        HRESULT ComputeArea(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out float area);

        [PreserveSig]
        HRESULT ComputeLength(ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, out float length);

        [PreserveSig]
        HRESULT ComputePointAtLength(float length, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ref D2D1_POINT_2F point, ref D2D1_POINT_2F unitTangentVector);

        [PreserveSig]
        HRESULT Widen(float strokeWidth, ID2D1StrokeStyle strokeStyle, ref D2D1_MATRIX_3X2_F worldTransform, float flatteningTolerance, ID2D1SimplifiedGeometrySink geometrySink);
    }
}
