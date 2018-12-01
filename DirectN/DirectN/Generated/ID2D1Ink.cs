// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(538,1)
using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    /// <summary>
    /// Represents a single continuous stroke of variable-width ink, as defined by a series of Bezier segments and widths.
    /// </summary>
    [Guid("b499923b-7029-478f-a8b3-432c7c5f5312"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Ink
    {
        [PreserveSig]
        void SetStartPoint(/* _In_ */ ref D2D1_INK_POINT startPoint);
        
        [PreserveSig]
        D2D1_INK_POINT GetStartPoint();
        
        [PreserveSig]
        HRESULT AddSegments(/* _In_reads_(segmentsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_INK_BEZIER_SEGMENT[] segments, uint segmentsCount);
        
        [PreserveSig]
        HRESULT RemoveSegmentsAtEnd(uint segmentsCount);
        
        [PreserveSig]
        HRESULT SetSegments(uint startSegment, /* _In_reads_(segmentsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D1_INK_BEZIER_SEGMENT[] segments, uint segmentsCount);
        
        [PreserveSig]
        HRESULT SetSegmentAtEnd(/* _In_ */ ref D2D1_INK_BEZIER_SEGMENT segment);
        
        [PreserveSig]
        uint GetSegmentCount();
        
        [PreserveSig]
        HRESULT GetSegments(uint startSegment, /* _Out_writes_(segmentsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D1_INK_BEZIER_SEGMENT[] segments, uint segmentsCount);
        
        [PreserveSig]
        HRESULT StreamAsGeometry(/* _In_opt_ */ ID2D1InkStyle inkStyle, /* optional(D2D1_MATRIX_3X2_F) */ IntPtr worldTransform, float flatteningTolerance, /* _In_ */ ref ID2D1SimplifiedGeometrySink geometrySink);
        
        [PreserveSig]
        HRESULT GetBounds(/* _In_opt_ */ ID2D1InkStyle inkStyle, /* optional(D2D1_MATRIX_3X2_F) */ IntPtr worldTransform, /* _Out_ */ out D2D1_RECT_F bounds);
    }
}
