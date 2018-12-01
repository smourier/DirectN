// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3339,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("05a9bf42-223f-4441-b5fb-8263685f55e9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout4 : IDWriteTextLayout3
    {
        // IDWriteTextLayout3
        [PreserveSig]
        new HRESULT InvalidateLayout();
        
        [PreserveSig]
        new HRESULT SetLineSpacing(/* _In_ */ ref DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        new HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        new HRESULT GetLineMetrics(/* _Out_writes_to_opt_(maxLineCount, *actualLineCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_METRICS1[] lineMetrics, uint maxLineCount, /* _Out_ */ out uint actualLineCount);
        
        // IDWriteTextLayout4
        [PreserveSig]
        HRESULT SetFontAxisValues(/* _In_reads_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        uint GetFontAxisValueCount(uint currentPosition);
        
        [PreserveSig]
        HRESULT GetFontAxisValues(uint currentPosition, /* _Out_writes_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, /* _Out_opt_ */ out DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes();
        
        [PreserveSig]
        HRESULT SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes);
    }
}
