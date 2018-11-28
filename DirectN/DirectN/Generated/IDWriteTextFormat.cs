using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9c906818-31d7-4fd3-a151-7c5e225db55a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteTextFormat
    {
        [PreserveSig]
        HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment);

        [PreserveSig]
        HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);

        [PreserveSig]
        HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping);

        [PreserveSig]
        HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection);

        [PreserveSig]
        HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection);

        [PreserveSig]
        HRESULT SetIncrementalTabStop(float incrementalTabStop);

        [PreserveSig]
        HRESULT SetTrimming(ref DWRITE_TRIMMING trimmingOptions, IDWriteInlineObject trimmingSign);

        [PreserveSig]
        HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline);

        [PreserveSig]
        DWRITE_TEXT_ALIGNMENT GetTextAlignment();

        [PreserveSig]
        DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment();

        [PreserveSig]
        DWRITE_WORD_WRAPPING GetWordWrapping();

        [PreserveSig]
        DWRITE_READING_DIRECTION GetReadingDirection();

        [PreserveSig]
        DWRITE_FLOW_DIRECTION GetFlowDirection();

        [PreserveSig]
        float GetIncrementalTabStop();

        [PreserveSig]
        HRESULT GetTrimming(out DWRITE_TRIMMING trimmingOptions, out IDWriteInlineObject trimmingSign);

        [PreserveSig]
        HRESULT GetLineSpacing(out DWRITE_LINE_SPACING_METHOD lineSpacingMethod, out float lineSpacing, out float baseline);

        [PreserveSig]
        HRESULT GetFontCollection(out IDWriteFontCollection fontCollection);

        [PreserveSig]
        int GetFontFamilyNameLength();

        [PreserveSig]
        HRESULT GetFontFamilyName([MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, int nameSize);

        [PreserveSig]
        DWRITE_FONT_WEIGHT GetFontWeight();

        [PreserveSig]
        DWRITE_FONT_STYLE GetFontStyle();

        [PreserveSig]
        DWRITE_FONT_STRETCH GetFontStretch();

        [PreserveSig]
        float GetFontSize();

        [PreserveSig]
        int GetLocaleNameLength();

        [PreserveSig]
        HRESULT GetLocaleName([MarshalAs(UnmanagedType.LPWStr)] string localeName, int nameSize);
    }
}
