// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(1595,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFont interface represents a physical font in a font collection.
    /// </summary>
    [ComImport, Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFont
    {
        [PreserveSig]
        HRESULT GetFontFamily(/* _COM_Outptr_ */ out IDWriteFontFamily fontFamily);
        
        [PreserveSig]
        DWRITE_FONT_WEIGHT GetWeight();
        
        [PreserveSig]
        DWRITE_FONT_STRETCH GetStretch();
        
        [PreserveSig]
        DWRITE_FONT_STYLE GetStyle();
        
        [PreserveSig]
        bool IsSymbolFont();
        
        [PreserveSig]
        HRESULT GetFaceNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings informationalStrings, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        DWRITE_FONT_SIMULATIONS GetSimulations();
        
        [PreserveSig]
        void GetMetrics(/* _Out_ */ out DWRITE_FONT_METRICS fontMetrics);
        
        [PreserveSig]
        HRESULT HasCharacter(uint unicodeValue, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT CreateFontFace(/* _COM_Outptr_ */ out IDWriteFontFace fontFace);
    }
}
