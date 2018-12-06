// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(702,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_L = DirectN.tagRECT;

namespace DirectN
{
    [Guid("36bfdcb6-9739-435d-a30d-a653beff6a6f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DrawTransform : ID2D1Transform
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1Transform
        [PreserveSig]
        new HRESULT MapOutputRectToInputRects(/* _In_ */ ref D2D1_RECT_L outputRect, /* _Out_writes_(inputRectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D1_RECT_L[] inputRects, uint inputRectsCount);
        
        [PreserveSig]
        new HRESULT MapInputRectsToOutputRect(/* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D1_RECT_L[] inputRects, /* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D1_RECT_L[] inputOpaqueSubRects, uint inputRectCount, /* _Out_ */ out D2D1_RECT_L outputRect, /* _Out_ */ out D2D1_RECT_L outputOpaqueSubRect);
        
        [PreserveSig]
        new HRESULT MapInvalidRect(uint inputIndex, D2D1_RECT_L invalidInputRect, /* _Out_ */ out D2D1_RECT_L invalidOutputRect);
        
        // ID2D1DrawTransform
        [PreserveSig]
        HRESULT SetDrawInfo(/* _In_ */ ID2D1DrawInfo drawInfo);
    }
}
