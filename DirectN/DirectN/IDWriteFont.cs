using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("acd16696-8c14-4f5d-877e-fe3fc1d32737"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFont
    {
        [PreserveSig]
        HRESULT GetFontFamily(out IDWriteFontFamily fontFamily);

        [PreserveSig]
        DWRITE_FONT_WEIGHT GetWeight();

        [PreserveSig]
        DWRITE_FONT_STRETCH GetStretch();

        [PreserveSig]
        DWRITE_FONT_STYLE GetStyle();

        [PreserveSig]
        bool IsSymbolFont();

        [PreserveSig]
        HRESULT GetFaceNames(out IDWriteLocalizedStrings names);

        [PreserveSig]
        HRESULT GetInformationalStrings(
            DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            out IDWriteLocalizedStrings informationalStrings,
            out bool exists
            );

        [PreserveSig]
        DWRITE_FONT_SIMULATIONS GetSimulations();

        [PreserveSig]
        void GetMetrics(out DWRITE_FONT_METRICS fontMetrics);

        [PreserveSig]
        HRESULT HasCharacter(uint unicodeValue, out bool exists);

        [PreserveSig]
        HRESULT CreateFontFace(out IDWriteFontFace fontFace);
    }
}
