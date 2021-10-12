// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(435,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The text analyzer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.
    /// </summary>
    [ComImport, Guid("553a9ff3-5693-4df7-b52b-74806f7f2eb9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalyzer2 : IDWriteTextAnalyzer1
    {
        // IDWriteTextAnalyzer
        [PreserveSig]
        new HRESULT AnalyzeScript(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        new HRESULT AnalyzeBidi(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        new HRESULT AnalyzeNumberSubstitution(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        new HRESULT AnalyzeLineBreakpoints(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        new HRESULT GetGlyphs(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, int textLength, /* _In_ */ IDWriteFontFace fontFace, bool isSideways, bool isRightToLeft, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_opt_ */ IDWriteNumberSubstitution numberSubstitution, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 10)] DWRITE_TYPOGRAPHIC_FEATURES[] features, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 10)] uint[] featureRangeLengths, int featureRanges, int maxGlyphCount, /* _Out_writes_(textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] clusterMap, /* _Out_writes_(textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, /* _Out_writes_(maxGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)] ushort[] glyphIndices, /* _Out_writes_(maxGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, /* _Out_ */ out uint actualGlyphCount);
        
        [PreserveSig]
        new HRESULT GetGlyphPlacements(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _Inout_updates_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, int textLength, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] ushort[] glyphIndices, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, int glyphCount, /* _In_ */ IDWriteFontFace fontFace, float fontEmSize, bool isSideways, bool isRightToLeft, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 15)] DWRITE_TYPOGRAPHIC_FEATURES[] features, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 15)] uint[] featureRangeLengths, int featureRanges, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] float[] glyphAdvances, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_GLYPH_OFFSET[] glyphOffsets);
        
        [PreserveSig]
        new HRESULT GetGdiCompatibleGlyphPlacements(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, int textLength, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] ushort[] glyphIndices, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, int glyphCount, /* _In_ */ IDWriteFontFace fontFace, float fontEmSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, bool isSideways, bool isRightToLeft, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 18)] DWRITE_TYPOGRAPHIC_FEATURES[] features, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 18)] uint[] featureRangeLengths, int featureRanges, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] float[] glyphAdvances, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_GLYPH_OFFSET[] glyphOffsets);
        
        // IDWriteTextAnalyzer1
        [PreserveSig]
        new HRESULT ApplyCharacterSpacing(float leadingSpacing, float trailingSpacing, float minimumAdvanceWidth, int textLength, int glyphCount, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] glyphAdvances, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] glyphOffsets, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] modifiedGlyphAdvances, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] modifiedGlyphOffsets);
        
        [PreserveSig]
        new HRESULT GetBaseline(/* _In_ */ IDWriteFontFace fontFace, DWRITE_BASELINE baseline, bool isVertical, bool isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _Out_ */ out int baselineCoordinate, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT AnalyzeVerticalGlyphOrientation(/* _In_ */ IDWriteTextAnalysisSource1 analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink1 analysisSink);
        
        [PreserveSig]
        new HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, bool isSideways, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        new HRESULT GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _Out_ */ out DWRITE_SCRIPT_PROPERTIES scriptProperties);
        
        [PreserveSig]
        new HRESULT GetTextComplexity(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, int textLength, /* _In_ */ IDWriteFontFace fontFace, /* _Out_ */ out bool isTextSimple, /* _Out_range_(0, textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] uint[] textLengthRead, /* _Out_writes_to_opt_(textLength, *textLengthRead) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices);
        
        [PreserveSig]
        new HRESULT GetJustificationOpportunities(/* _In_opt_ */ IDWriteFontFace fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, int textLength, int glyphCount, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_JUSTIFICATION_OPPORTUNITY[] justificationOpportunities);
        
        [PreserveSig]
        new HRESULT JustifyGlyphAdvances(float lineWidth, int glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_JUSTIFICATION_OPPORTUNITY[] justificationOpportunities, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] glyphAdvances, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_GLYPH_OFFSET[] glyphOffsets, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] justifiedGlyphAdvances, /* _Out_writes_opt_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_GLYPH_OFFSET[] justifiedGlyphOffsets);
        
        [PreserveSig]
        new HRESULT GetJustifiedGlyphs(/* _In_opt_ */ IDWriteFontFace fontFace, float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, int textLength, int glyphCount, int maxGlyphCount, /* _In_reads_opt_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ushort[] glyphIndices, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] glyphAdvances, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] justifiedGlyphAdvances, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] justifiedGlyphOffsets, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProperties, /* _Out_range_(glyphCount, maxGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] actualGlyphCount, /* _Out_writes_opt_(textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] modifiedClusterMap, /* _Out_writes_to_(maxGlyphCount, *actualGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] ushort[] modifiedGlyphIndices, /* _Out_writes_to_(maxGlyphCount, *actualGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] float[] modifiedGlyphAdvances, /* _Out_writes_to_(maxGlyphCount, *actualGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_GLYPH_OFFSET[] modifiedGlyphOffsets);
        
        // IDWriteTextAnalyzer2
        [PreserveSig]
        HRESULT GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, bool isSideways, float originX, float originY, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        HRESULT GetTypographicFeatures(IDWriteFontFace fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, int maxTagCount, /* _Out_ */ out uint actualTagCount, /* _Out_writes_(maxTagCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DWRITE_FONT_FEATURE_TAG tags);
        
        [PreserveSig]
        HRESULT CheckTypographicFeature(IDWriteFontFace fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, DWRITE_FONT_FEATURE_TAG featureTag, int glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ushort[] glyphIndices, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] featureApplies);
    }
}
