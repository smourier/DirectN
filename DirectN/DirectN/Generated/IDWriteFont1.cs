// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(1348,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFont interface represents a physical font in a font collection.
    /// </summary>
    [ComImport, Guid("acd16696-8c14-4f5d-877e-fe3fc1d32738"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFont1 : IDWriteFont
    {
        // IDWriteFont
        [PreserveSig]
        new HRESULT GetFontFamily(/* _COM_Outptr_ */ out IDWriteFontFamily fontFamily);
        
        [PreserveSig]
        new DWRITE_FONT_WEIGHT GetWeight();
        
        [PreserveSig]
        new DWRITE_FONT_STRETCH GetStretch();
        
        [PreserveSig]
        new DWRITE_FONT_STYLE GetStyle();
        
        [PreserveSig]
        new bool IsSymbolFont();
        
        [PreserveSig]
        new HRESULT GetFaceNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        new HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings informationalStrings, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new DWRITE_FONT_SIMULATIONS GetSimulations();
        
        [PreserveSig]
        new void GetMetrics(/* _Out_ */ out DWRITE_FONT_METRICS fontMetrics);
        
        [PreserveSig]
        new HRESULT HasCharacter(uint unicodeValue, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT CreateFontFace(/* _COM_Outptr_ */ out IDWriteFontFace fontFace);
        
        // IDWriteFont1
        [PreserveSig]
        void GetMetrics(/* _Out_ */ out DWRITE_FONT_METRICS1 fontMetrics);
        
        [PreserveSig]
        void GetPanose(/* _Out_ */ out DWRITE_PANOSE panose);
        
        [PreserveSig]
        HRESULT GetUnicodeRanges(int maxRangeCount, /* _Out_writes_to_opt_(maxRangeCount, *actualRangeCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] DWRITE_UNICODE_RANGE[] unicodeRanges, /* _Out_ */ out uint actualRangeCount);
        
        [PreserveSig]
        bool IsMonospacedFont();
    }
}
