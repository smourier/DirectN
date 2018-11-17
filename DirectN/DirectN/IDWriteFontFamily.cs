using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("da20d8ef-812a-4c43-9802-62ec4abd7add"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontFamily : IDWriteFontList
    {
        // IDWriteFontList
        [PreserveSig]
        new HRESULT GetFontCollection(out IDWriteFontCollection fontCollection);

        [PreserveSig]
        new int GetFontCount();

        [PreserveSig]
        new HRESULT GetFont(int index, out IDWriteFont font);

        // IDWriteFontFamily 
        [PreserveSig]
        HRESULT GetFamilyNames(out IDWriteLocalizedStrings names);

        [PreserveSig]
        HRESULT GetFirstMatchingFont(
            DWRITE_FONT_WEIGHT weight,
            DWRITE_FONT_STRETCH stretch,
            DWRITE_FONT_STYLE style,
            out IDWriteFont matchingFont
            );

        [PreserveSig]
        HRESULT GetMatchingFonts(
            DWRITE_FONT_WEIGHT weight,
            DWRITE_FONT_STRETCH stretch,
            DWRITE_FONT_STYLE style,
            out IDWriteFontList matchingFonts
            );
    }
}
