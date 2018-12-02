// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(749,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_L = DirectN.tagRECT;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by a transform author to provide a CPU based source effect.
    /// </summary>
    [Guid("db1800dd-0c34-4cf9-be90-31cc0a5653e1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SourceTransform : ID2D1Transform
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
        
        // ID2D1SourceTransform
        [PreserveSig]
        HRESULT SetRenderInfo(/* _In_ */ ID2D1RenderInfo renderInfo);
        
        [PreserveSig]
        HRESULT Draw(/* _In_ */ ID2D1Bitmap1 target, /* _In_ */ ref D2D1_RECT_L drawRect, D2D_POINT_2U targetOrigin);
    }
}
