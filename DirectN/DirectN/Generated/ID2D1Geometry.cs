// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(1423,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a geometry resource and defines a set of helper methods for manipulating and measuring geometric shapes. Interfaces that inherit from ID2D1Geometry define specific shapes.
    /// </summary>
    [Guid("2cd906a1-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Geometry : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Geometry
        [PreserveSig]
        HRESULT GetBounds(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        HRESULT GetWidenedBounds(float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        HRESULT StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out bool contains);
        
        [PreserveSig]
        HRESULT FillContainsPoint(D2D_POINT_2F point, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out bool contains);
        
        [PreserveSig]
        HRESULT CompareWithGeometry(/* _In_ */ ID2D1Geometry inputGeometry, /* _In_opt_ */ ref D2D_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, /* _Out_ */ out D2D1_GEOMETRY_RELATION relation);
        
        [PreserveSig]
        HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        HRESULT Tessellate(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1TessellationSink tessellationSink);
        
        [PreserveSig]
        HRESULT CombineWithGeometry(/* _In_ */ ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, /* _In_opt_ */ ref D2D_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        HRESULT Outline(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        HRESULT ComputeArea(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out float area);
        
        [PreserveSig]
        HRESULT ComputeLength(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out float length);
        
        [PreserveSig]
        HRESULT ComputePointAtLength(float length, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_opt_ */ out D2D_POINT_2F point, /* _Out_opt_ */ out D2D_POINT_2F unitTangentVector);
        
        [PreserveSig]
        HRESULT Widen(float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
    }
}
