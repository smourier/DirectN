// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(2049,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The format of text used for text layout.  <remarks> This object may not be thread-safe and it may carry the state of text format change. </remarks>
    /// </summary>
    [ComImport, Guid("9c906818-31d7-4fd3-a151-7c5e225db55a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextFormat
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
        HRESULT SetTrimming(/* _In_ */ ref DWRITE_TRIMMING trimmingOptions, /* _In_opt_ */ IDWriteInlineObject trimmingSign);
        
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
        HRESULT GetTrimming(/* _Out_ */ out DWRITE_TRIMMING trimmingOptions, /* _COM_Outptr_ */ out IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        HRESULT GetLineSpacing(/* _Out_ */ out DWRITE_LINE_SPACING_METHOD lineSpacingMethod, /* _Out_ */ out float lineSpacing, /* _Out_ */ out float baseline);
        
        [PreserveSig]
        HRESULT GetFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        uint GetFontFamilyNameLength();
        
        [PreserveSig]
        HRESULT GetFontFamilyName(/* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, uint nameSize);
        
        [PreserveSig]
        DWRITE_FONT_WEIGHT GetFontWeight();
        
        [PreserveSig]
        DWRITE_FONT_STYLE GetFontStyle();
        
        [PreserveSig]
        DWRITE_FONT_STRETCH GetFontStretch();
        
        [PreserveSig]
        float GetFontSize();
        
        [PreserveSig]
        uint GetLocaleNameLength();
        
        [PreserveSig]
        HRESULT GetLocaleName(/* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint nameSize);
    }
}
