// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(715,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface implemented by a transform author to provide a Compute Shader based effect.
    /// </summary>
    [Guid("0d85573c-01e3-4f7d-bfd9-0d60608bf3c3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ComputeTransform : ID2D1Transform
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1Transform
        [PreserveSig]
        new HRESULT MapOutputRectToInputRects(/* _In_ */ ref tagRECT outputRect, /* _Out_writes_(inputRectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputRects, uint inputRectsCount);
        
        [PreserveSig]
        new HRESULT MapInputRectsToOutputRect(/* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputRects, /* _In_reads_(inputRectCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] inputOpaqueSubRects, uint inputRectCount, /* _Out_ */ out tagRECT outputRect, /* _Out_ */ out tagRECT outputOpaqueSubRect);
        
        [PreserveSig]
        new HRESULT MapInvalidRect(uint inputIndex, tagRECT invalidInputRect, /* _Out_ */ out tagRECT invalidOutputRect);
        
        // ID2D1ComputeTransform
        [PreserveSig]
        HRESULT SetComputeInfo(/* _In_ */ ID2D1ComputeInfo computeInfo);
        
        [PreserveSig]
        HRESULT CalculateThreadgroups(/* _In_ */ ref tagRECT outputRect, /* _Out_ */ out uint dimensionX, /* _Out_ */ out uint dimensionY, /* _Out_ */ out uint dimensionZ);
    }
}
