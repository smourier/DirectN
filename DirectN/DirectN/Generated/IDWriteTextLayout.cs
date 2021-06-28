// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(3771,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteTextLayout interface represents a block of text after it has been fully analyzed and formatted.
    /// </summary>
    [ComImport, Guid("53737037-6d14-410b-9bfe-0b182bb70961"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout : IDWriteTextFormat
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
        HRESULT SetMaxWidth(float maxWidth);
        
        [PreserveSig]
        HRESULT SetMaxHeight(float maxHeight);
        
        [PreserveSig]
        HRESULT SetFontCollection(/* _In_ */ IDWriteFontCollection fontCollection, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetFontFamilyName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetUnderline(bool hasUnderline, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetStrikethrough(bool hasStrikethrough, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetDrawingEffect([MarshalAs(UnmanagedType.IUnknown)] object drawingEffect, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetInlineObject(/* _In_ */ IDWriteInlineObject inlineObject, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetTypography(/* _In_ */ IDWriteTypography typography, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        HRESULT SetLocaleName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, DWRITE_TEXT_RANGE textRange);
        
        [PreserveSig]
        float GetMaxWidth();
        
        [PreserveSig]
        float GetMaxHeight();
        
        [PreserveSig]
        HRESULT GetFontCollection(uint currentPosition, /* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetFontFamilyNameLength(uint currentPosition, /* _Out_ */ out uint nameLength, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetFontFamilyName(uint currentPosition, /* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, uint nameSize, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetFontWeight(uint currentPosition, /* _Out_ */ out DWRITE_FONT_WEIGHT fontWeight, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetFontStyle(uint currentPosition, /* _Out_ */ out DWRITE_FONT_STYLE fontStyle, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetFontStretch(uint currentPosition, /* _Out_ */ out DWRITE_FONT_STRETCH fontStretch, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetFontSize(uint currentPosition, /* _Out_ */ out float fontSize, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetUnderline(uint currentPosition, /* _Out_ */ out bool hasUnderline, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetStrikethrough(uint currentPosition, /* _Out_ */ out bool hasStrikethrough, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetDrawingEffect(uint currentPosition, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object drawingEffect, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetInlineObject(uint currentPosition, /* _COM_Outptr_ */ out IDWriteInlineObject inlineObject, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetTypography(uint currentPosition, /* _COM_Outptr_ */ out IDWriteTypography typography, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetLocaleNameLength(uint currentPosition, /* _Out_ */ out uint nameLength, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT GetLocaleName(uint currentPosition, /* _Out_writes_z_(nameSize) */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, uint nameSize, /* optional(DWRITE_TEXT_RANGE) */ IntPtr textRange);
        
        [PreserveSig]
        HRESULT Draw(/* optional(void) */ IntPtr clientDrawingContext, /* _In_ */ IDWriteTextRenderer renderer, float originX, float originY);
        
        [PreserveSig]
        HRESULT GetLineMetrics(/* _Out_writes_opt_(maxLineCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_LINE_METRICS[] lineMetrics, int maxLineCount, /* _Out_ */ out uint actualLineCount);
        
        [PreserveSig]
        HRESULT GetMetrics(/* _Out_ */ out DWRITE_TEXT_METRICS textMetrics);
        
        [PreserveSig]
        HRESULT GetOverhangMetrics(/* _Out_ */ out DWRITE_OVERHANG_METRICS overhangs);
        
        [PreserveSig]
        HRESULT GetClusterMetrics(/* _Out_writes_opt_(maxClusterCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_CLUSTER_METRICS[] clusterMetrics, int maxClusterCount, /* _Out_ */ out uint actualClusterCount);
        
        [PreserveSig]
        HRESULT DetermineMinWidth(/* _Out_ */ out float minWidth);
        
        [PreserveSig]
        HRESULT HitTestPoint(float pointX, float pointY, /* _Out_ */ out bool isTrailingHit, /* _Out_ */ out bool isInside, /* _Out_ */ out DWRITE_HIT_TEST_METRICS hitTestMetrics);
        
        [PreserveSig]
        HRESULT HitTestTextPosition(uint textPosition, bool isTrailingHit, /* _Out_ */ out float pointX, /* _Out_ */ out float pointY, /* _Out_ */ out DWRITE_HIT_TEST_METRICS hitTestMetrics);
        
        [PreserveSig]
        HRESULT HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, /* _Out_writes_opt_(maxHitTestMetricsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_HIT_TEST_METRICS[] hitTestMetrics, int maxHitTestMetricsCount, /* _Out_ */ out uint actualHitTestMetricsCount);
    }
}
