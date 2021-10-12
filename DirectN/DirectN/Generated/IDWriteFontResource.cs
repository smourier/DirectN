// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(2743,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface to return axis information for a font resource and create specific font face instances.
    /// </summary>
    [ComImport, Guid("1f803a76-6871-48e8-987f-b975551c50f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontResource
    {
        [PreserveSig]
        HRESULT GetFontFile(/* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        uint GetFontFaceIndex();
        
        [PreserveSig]
        uint GetFontAxisCount();
        
        [PreserveSig]
        HRESULT GetDefaultFontAxisValues(/* _Out_writes_(fontAxisValueCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount);
        
        [PreserveSig]
        HRESULT GetFontAxisRanges(/* _Out_writes_(fontAxisRangeCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_RANGE[] fontAxisRanges, int fontAxisRangeCount);
        
        [PreserveSig]
        DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes(uint axisIndex);
        
        [PreserveSig]
        HRESULT GetAxisNames(uint axisIndex, /* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        uint GetAxisValueNameCount(uint axisIndex);
        
        [PreserveSig]
        HRESULT GetAxisValueNames(uint axisIndex, uint axisValueIndex, /* _Out_ */ out DWRITE_FONT_AXIS_RANGE fontAxisRange, /* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        bool HasVariations();
        
        [PreserveSig]
        HRESULT CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, /* _In_reads_(fontAxisValueCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontFace5 fontFace);
        
        [PreserveSig]
        HRESULT CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, /* _In_reads_(fontAxisValueCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontFaceReference1 fontFaceReference);
    }
}
