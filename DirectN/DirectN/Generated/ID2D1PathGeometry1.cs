// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(970,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The ID2D1PathGeometry1 interface adds functionality to ID2D1PathGeometry. In particular, it provides the path geometry-specific ComputePointAndSegmentAtLength method.
    /// </summary>
    [ComImport, Guid("62baa2d2-ab54-41b7-b872-787e0106a421"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1PathGeometry1 : ID2D1PathGeometry
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
        
        // ID2D1PathGeometry
        [PreserveSig]
        new HRESULT Open(/* _COM_Outptr_ */ out ID2D1GeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT Stream(/* _In_ */ ID2D1GeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT GetSegmentCount(/* _Out_ */ out uint count);
        
        [PreserveSig]
        new HRESULT GetFigureCount(/* _Out_ */ out uint count);
        
        // ID2D1PathGeometry1
        [PreserveSig]
        HRESULT ComputePointAndSegmentAtLength(float length, uint startSegment, /* optional(D2D_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _Out_ */ out D2D1_POINT_DESCRIPTION pointDescription);
    }
}
