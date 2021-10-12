// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(674,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by a transform author.
    /// </summary>
    [ComImport, Guid("ef1a287d-342a-4f76-8fdb-da0d6ea9f92b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Transform : ID2D1TransformNode
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1Transform
        [PreserveSig]
        HRESULT MapOutputRectToInputRects(/* _In_ */ ref tagRECT outputRect, /* _Out_writes_(inputRectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputRects, int inputRectsCount);
        
        [PreserveSig]
        HRESULT MapInputRectsToOutputRect(/* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputRects, /* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputOpaqueSubRects, int inputRectCount, /* _Out_ */ out tagRECT outputRect, /* _Out_ */ out tagRECT outputOpaqueSubRect);
        
        [PreserveSig]
        HRESULT MapInvalidRect(uint inputIndex, tagRECT invalidInputRect, /* _Out_ */ out tagRECT invalidOutputRect);
    }
}
