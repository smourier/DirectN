// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1729,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("07ddcd52-020e-4de8-ac33-6c953d83f92d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout3
    {
        [PreserveSig]
        HRESULT InvalidateLayout();
        
        [PreserveSig]
        HRESULT SetLineSpacing(/* _In_ */ ref DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        HRESULT GetLineMetrics(/* _Out_writes_to_opt_(maxLineCount, *actualLineCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_METRICS1[] lineMetrics, uint maxLineCount, /* _Out_ */ out uint actualLineCount);
    }
}
