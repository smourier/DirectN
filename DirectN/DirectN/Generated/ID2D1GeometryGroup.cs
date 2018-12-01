// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(2138,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a composite geometry, composed of other ID2D1Geometry objects.
    /// </summary>
    [Guid("2cd906a6-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GeometryGroup : ID2D1Geometry
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Geometry
        [PreserveSig]
        new HRESULT GetBounds(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        new HRESULT GetWidenedBounds(float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        new HRESULT StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out bool contains);
        
        [PreserveSig]
        new HRESULT FillContainsPoint(D2D_POINT_2F point, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out bool contains);
        
        [PreserveSig]
        new HRESULT CompareWithGeometry(/* _In_ */ ID2D1Geometry inputGeometry, /* _In_opt_ */ ref D2D_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, /* _Out_ */ out D2D1_GEOMETRY_RELATION relation);
        
        [PreserveSig]
        new HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT Tessellate(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1TessellationSink tessellationSink);
        
        [PreserveSig]
        new HRESULT CombineWithGeometry(/* _In_ */ ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, /* _In_opt_ */ ref D2D_MATRIX_3X2_F inputGeometryTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT Outline(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT ComputeArea(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out float area);
        
        [PreserveSig]
        new HRESULT ComputeLength(/* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out float length);
        
        [PreserveSig]
        new HRESULT ComputePointAtLength(float length, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_opt_ */ out D2D_POINT_2F point, /* _Out_opt_ */ out D2D_POINT_2F unitTangentVector);
        
        [PreserveSig]
        new HRESULT Widen(float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        // ID2D1GeometryGroup
        [PreserveSig]
        D2D1_FILL_MODE GetFillMode();
        
        [PreserveSig]
        uint GetSourceGeometryCount();
        
        [PreserveSig]
        void GetSourceGeometries(/* _Out_writes_(geometriesCount) */ out ID2D1Geometry[] geometries, uint geometriesCount);
    }
}
