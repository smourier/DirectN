// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(3396,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6d3b5641-e550-430d-a85b-b7bf48a93427"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextFormat3 : IDWriteTextFormat2
    {
        // IDWriteTextFormat2
        [PreserveSig]
        new HRESULT SetLineSpacing(/* _In_ */ ref DWRITE_LINE_SPACING lineSpacingOptions);
        
        [PreserveSig]
        new HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING lineSpacingOptions);
        
        // IDWriteTextFormat3
        [PreserveSig]
        HRESULT SetFontAxisValues(/* _In_reads_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount);
        
        [PreserveSig]
        uint GetFontAxisValueCount();
        
        [PreserveSig]
        HRESULT GetFontAxisValues(/* _Out_writes_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount);
        
        [PreserveSig]
        DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes();
        
        [PreserveSig]
        HRESULT SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes);
    }
}
