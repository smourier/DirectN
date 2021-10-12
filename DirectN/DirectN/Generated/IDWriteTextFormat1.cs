// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(253,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The format of text used for text layout.  <remarks> This object may not be thread-safe and it may carry the state of text format change. </remarks>
    /// </summary>
    [ComImport, Guid("5f174b49-0d8b-4cfb-8bca-f1cce9d06c67"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextFormat1 : IDWriteTextFormat
    {
        // IDWriteTextFormat
        [PreserveSig]
        new HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment);
        
        [PreserveSig]
        new HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);
        
        [PreserveSig]
        new HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping);
        
        [PreserveSig]
        new HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection);
        
        [PreserveSig]
        new HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection);
        
        [PreserveSig]
        new HRESULT SetIncrementalTabStop(float incrementalTabStop);
        
        [PreserveSig]
        new HRESULT SetTrimming(/* _In_ */ ref DWRITE_TRIMMING trimmingOptions, /* _In_opt_ */ IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        new HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline);
        
        [PreserveSig]
        new DWRITE_TEXT_ALIGNMENT GetTextAlignment();
        
        [PreserveSig]
        new DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment();
        
        [PreserveSig]
        new DWRITE_WORD_WRAPPING GetWordWrapping();
        
        [PreserveSig]
        new DWRITE_READING_DIRECTION GetReadingDirection();
        
        [PreserveSig]
        new DWRITE_FLOW_DIRECTION GetFlowDirection();
        
        [PreserveSig]
        new float GetIncrementalTabStop();
        
        [PreserveSig]
        new HRESULT GetTrimming(/* _Out_ */ out DWRITE_TRIMMING trimmingOptions, /* _COM_Outptr_ */ out IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        new HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING_METHOD lineSpacingMethod, /* _Out_ */ out float lineSpacing, /* _Out_ */ out float baseline);
        
        [PreserveSig]
        new HRESULT GetFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        new uint GetFontFamilyNameLength();
        
        [PreserveSig]
        new HRESULT GetFontFamilyName(/* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, uint nameSize);
        
        [PreserveSig]
        new DWRITE_FONT_WEIGHT GetFontWeight();
        
        [PreserveSig]
        new DWRITE_FONT_STYLE GetFontStyle();
        
        [PreserveSig]
        new DWRITE_FONT_STRETCH GetFontStretch();
        
        [PreserveSig]
        new float GetFontSize();
        
        [PreserveSig]
        new uint GetLocaleNameLength();
        
        [PreserveSig]
        new HRESULT GetLocaleName(/* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint nameSize);
        
        // IDWriteTextFormat1
        [PreserveSig]
        HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);
        
        [PreserveSig]
        DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation();
        
        [PreserveSig]
        HRESULT SetLastLineWrapping(bool isLastLineWrappingEnabled);
        
        [PreserveSig]
        bool GetLastLineWrapping();
        
        [PreserveSig]
        HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment);
        
        [PreserveSig]
        DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment();
        
        [PreserveSig]
        HRESULT SetFontFallback(IDWriteFontFallback fontFallback);
        
        [PreserveSig]
        HRESULT GetFontFallback(/* __out */ out IDWriteFontFallback fontFallback);
    }
}
