// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_1.h(1802,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteTextLayout1 interface represents a block of text after it has been fully analyzed and formatted.
    /// </summary>
    [ComImport, Guid("9064d822-80a7-465c-a986-df65f78b8feb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout1 : IDWriteTextLayout
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
        
        // IDWriteTextLayout
        [PreserveSig]
        new HRESULT SetMaxWidth(float maxWidth);
        
        [PreserveSig]
        new HRESULT SetMaxHeight(float maxHeight);
        
        [PreserveSig]
        new HRESULT SetFontCollection(/* _In_ */ IDWriteFontCollection fontCollection, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontFamilyName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetUnderline(bool hasUnderline, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetStrikethrough(bool hasStrikethrough, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetDrawingEffect([MarshalAs(UnmanagedType.IUnknown)] object drawingEffect, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetInlineObject(/* _In_ */ IDWriteInlineObject inlineObject, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetTypography(/* _In_ */ IDWriteTypography typography, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new HRESULT SetLocaleName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        new float GetMaxWidth();
        
        [PreserveSig]
        new float GetMaxHeight();
        
        [PreserveSig]
        new HRESULT GetFontCollection(uint currentPosition, /* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetFontFamilyNameLength(uint currentPosition, /* _Out_ */ out uint nameLength, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetFontFamilyName(uint currentPosition, /* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, uint nameSize, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetFontWeight(uint currentPosition, /* _Out_ */ out DWRITE_FONT_WEIGHT fontWeight, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetFontStyle(uint currentPosition, /* _Out_ */ out DWRITE_FONT_STYLE fontStyle, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetFontStretch(uint currentPosition, /* _Out_ */ out DWRITE_FONT_STRETCH fontStretch, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetFontSize(uint currentPosition, /* _Out_ */ out float fontSize, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetUnderline(uint currentPosition, /* _Out_ */ out bool hasUnderline, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetStrikethrough(uint currentPosition, /* _Out_ */ out bool hasStrikethrough, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetDrawingEffect(uint currentPosition, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object drawingEffect, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetInlineObject(uint currentPosition, /* _COM_Outptr_ */ out IDWriteInlineObject inlineObject, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetTypography(uint currentPosition, /* _COM_Outptr_ */ out IDWriteTypography typography, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetLocaleNameLength(uint currentPosition, /* _Out_ */ out uint nameLength, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT GetLocaleName(uint currentPosition, /* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint nameSize, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        new HRESULT Draw(/* optional(void) */ IntPtr clientDrawingContext, /* _In_ */ IDWriteTextRenderer renderer, float originX, float originY);
        
        [PreserveSig]
        new HRESULT GetLineMetrics(/* _Out_writes_opt_(maxLineCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_METRICS[] lineMetrics, int maxLineCount, /* _Out_ */ out uint actualLineCount);
        
        [PreserveSig]
        new HRESULT GetMetrics(/* _Out_ */ out DWRITE_TEXT_METRICS textMetrics);
        
        [PreserveSig]
        new HRESULT GetOverhangMetrics(/* _Out_ */ out DWRITE_OVERHANG_METRICS overhangs);
        
        [PreserveSig]
        new HRESULT GetClusterMetrics(/* _Out_writes_opt_(maxClusterCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_CLUSTER_METRICS[] clusterMetrics, int maxClusterCount, /* _Out_ */ out uint actualClusterCount);
        
        [PreserveSig]
        new HRESULT DetermineMinWidth(/* _Out_ */ out float minWidth);
        
        [PreserveSig]
        new HRESULT HitTestPoint(float pointX, float pointY, /* _Out_ */ out bool isTrailingHit, /* _Out_ */ out bool isInside, /* _Out_ */ out DWRITE_HIT_TEST_METRICS hitTestMetrics);
        
        [PreserveSig]
        new HRESULT HitTestTextPosition(uint textPosition, bool isTrailingHit, /* _Out_ */ out float pointX, /* _Out_ */ out float pointY, /* _Out_ */ out DWRITE_HIT_TEST_METRICS hitTestMetrics);
        
        [PreserveSig]
        new HRESULT HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, /* _Out_writes_opt_(maxHitTestMetricsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_HIT_TEST_METRICS[] hitTestMetrics, int maxHitTestMetricsCount, /* _Out_ */ out uint actualHitTestMetricsCount);
        
        // IDWriteTextLayout1
        [PreserveSig]
        HRESULT SetPairKerning(bool isPairKerningEnabled, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT GetPairKerning(uint currentPosition, /* _Out_ */ out bool isPairKerningEnabled, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT SetCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT GetCharacterSpacing(uint currentPosition, /* _Out_ */ out float leadingSpacing, /* _Out_ */ out float trailingSpacing, /* _Out_ */ out float minimumAdvanceWidth, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
    }
}
