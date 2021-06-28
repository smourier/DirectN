// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(702,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by a transform author to provide a GPU-based effect.
    /// </summary>
    [ComImport, Guid("36bfdcb6-9739-435d-a30d-a653beff6a6f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DrawTransform : ID2D1Transform
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
        
        // ID2D1DrawTransform
        [PreserveSig]
        HRESULT SetDrawInfo(/* _In_ */ ID2D1DrawInfo drawInfo);
    }
}
