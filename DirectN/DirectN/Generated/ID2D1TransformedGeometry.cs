// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(2157,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a geometry that has been transformed.
    /// </summary>
    [ComImport, Guid("2cd906bb-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1TransformedGeometry : ID2D1Geometry
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1Geometry
        [PreserveSig]
        new HRESULT GetBounds(/* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        new HRESULT GetWidenedBounds(float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        new HRESULT StrokeContainsPoint(D2D_POINT_2F point, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _Out_ */ out bool contains);
        
        [PreserveSig]
        new HRESULT FillContainsPoint(D2D_POINT_2F point, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _Out_ */ out bool contains);
        
        [PreserveSig]
        new HRESULT CompareWithGeometry(/* _In_ */ ID2D1Geometry inputGeometry, /* optional(D2D_MATRIX_3X2_F) */ IntPtr inputGeometryTransform, float flatteningTolerance, /* _Out_ */ out D2D1_GEOMETRY_RELATION relation);
        
        [PreserveSig]
        new HRESULT Simplify(D2D1_GEOMETRY_SIMPLIFICATION_OPTION simplificationOption, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT Tessellate(/* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _In_ */ ID2D1TessellationSink tessellationSink);
        
        [PreserveSig]
        new HRESULT CombineWithGeometry(/* _In_ */ ID2D1Geometry inputGeometry, D2D1_COMBINE_MODE combineMode, /* optional(D2D_MATRIX_3X2_F) */ IntPtr inputGeometryTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT Outline(/* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT ComputeArea(/* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _Out_ */ out float area);
        
        [PreserveSig]
        new HRESULT ComputeLength(/* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _Out_ */ out float length);
        
        [PreserveSig]
        new HRESULT ComputePointAtLength(float length, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* optional(D2D_POINT_2F) */ IntPtr point, /* optional(D2D_POINT_2F) */ IntPtr unitTangentVector);
        
        [PreserveSig]
        new HRESULT Widen(float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _In_ */ ID2D1SimplifiedGeometrySink geometrySink);
        
        // ID2D1TransformedGeometry
        [PreserveSig]
        void GetSourceGeometry(/* _Outptr_ */ out ID2D1Geometry sourceGeometry);
        
        [PreserveSig]
        void GetTransform(/* _Out_ */ out D2D_MATRIX_3X2_F transform);
    }
}
