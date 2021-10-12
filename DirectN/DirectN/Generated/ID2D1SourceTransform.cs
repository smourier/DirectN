// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(749,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by a transform author to provide a CPU based source effect.
    /// </summary>
    [ComImport, Guid("db1800dd-0c34-4cf9-be90-31cc0a5653e1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1SourceTransform : ID2D1Transform
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1Transform
        [PreserveSig]
        new HRESULT MapOutputRectToInputRects(/* _In_ */ ref tagRECT outputRect, /* _Out_writes_(inputRectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputRects, int inputRectsCount);
        
        [PreserveSig]
        new HRESULT MapInputRectsToOutputRect(/* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputRects, /* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputOpaqueSubRects, int inputRectCount, /* _Out_ */ out tagRECT outputRect, /* _Out_ */ out tagRECT outputOpaqueSubRect);
        
        [PreserveSig]
        new HRESULT MapInvalidRect(uint inputIndex, tagRECT invalidInputRect, /* _Out_ */ out tagRECT invalidOutputRect);
        
        // ID2D1SourceTransform
        [PreserveSig]
        HRESULT SetRenderInfo(/* _In_ */ ID2D1RenderInfo renderInfo);
        
        [PreserveSig]
        HRESULT Draw(/* _In_ */ ID2D1Bitmap1 target, /* _In_ */ ref tagRECT drawRect, D2D_POINT_2U targetOrigin);
    }
}
