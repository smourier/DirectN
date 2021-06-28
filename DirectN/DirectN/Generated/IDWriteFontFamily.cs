// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(1544,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFontFamily interface represents a set of fonts that share the same design but are differentiated by weight, stretch, and style.
    /// </summary>
    [ComImport, Guid("da20d8ef-812a-4c43-9802-62ec4abd7add"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFamily : IDWriteFontList
    {
        // IDWriteFontList
        [PreserveSig]
        new HRESULT GetFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        new uint GetFontCount();
        
        [PreserveSig]
        new HRESULT GetFont(uint index, /* _COM_Outptr_ */ out IDWriteFont font);
        
        // IDWriteFontFamily
        [PreserveSig]
        HRESULT GetFamilyNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        HRESULT GetFirstMatchingFont(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, /* _COM_Outptr_ */ out IDWriteFont matchingFont);
        
        [PreserveSig]
        HRESULT GetMatchingFonts(DWRITE_FONT_WEIGHT weight, DWRITE_FONT_STRETCH stretch, DWRITE_FONT_STYLE style, /* _COM_Outptr_ */ out IDWriteFontList matchingFonts);
    }
}
