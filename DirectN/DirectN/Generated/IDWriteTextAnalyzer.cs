// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(2734,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Analyzes various text properties for complex script processing.
    /// </summary>
    [ComImport, Guid("b7e6163e-7f46-43b4-84b3-e4e6249c365d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextAnalyzer
    {
        [PreserveSig]
        HRESULT AnalyzeScript(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        HRESULT AnalyzeBidi(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        HRESULT AnalyzeNumberSubstitution(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        HRESULT AnalyzeLineBreakpoints(/* _In_ */ IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, /* _In_ */ IDWriteTextAnalysisSink analysisSink);
        
        [PreserveSig]
        HRESULT GetGlyphs(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, int textLength, /* _In_ */ IDWriteFontFace fontFace, bool isSideways, bool isRightToLeft, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_opt_ */ IDWriteNumberSubstitution numberSubstitution, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 10)] DWRITE_TYPOGRAPHIC_FEATURES[] features, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 10)] uint[] featureRangeLengths, int featureRanges, int maxGlyphCount, /* _Out_writes_(textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] clusterMap, /* _Out_writes_(textLength) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, /* _Out_writes_(maxGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)] ushort[] glyphIndices, /* _Out_writes_(maxGlyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 11)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, /* _Out_ */ out uint actualGlyphCount);
        
        [PreserveSig]
        HRESULT GetGlyphPlacements(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _Inout_updates_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, int textLength, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] ushort[] glyphIndices, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, int glyphCount, /* _In_ */ IDWriteFontFace fontFace, float fontEmSize, bool isSideways, bool isRightToLeft, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 15)] DWRITE_TYPOGRAPHIC_FEATURES[] features, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 15)] uint[] featureRangeLengths, int featureRanges, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] float[] glyphAdvances, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_GLYPH_OFFSET[] glyphOffsets);
        
        [PreserveSig]
        HRESULT GetGdiCompatibleGlyphPlacements(/* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPWStr)] string textString, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] clusterMap, /* _In_reads_(textLength) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] DWRITE_SHAPING_TEXT_PROPERTIES[] textProps, int textLength, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] ushort[] glyphIndices, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_SHAPING_GLYPH_PROPERTIES[] glyphProps, int glyphCount, /* _In_ */ IDWriteFontFace fontFace, float fontEmSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, bool isSideways, bool isRightToLeft, /* _In_ */ ref DWRITE_SCRIPT_ANALYSIS scriptAnalysis, /* _In_opt_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 18)] DWRITE_TYPOGRAPHIC_FEATURES[] features, /* _In_reads_opt_(featureRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 18)] uint[] featureRangeLengths, int featureRanges, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] float[] glyphAdvances, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] DWRITE_GLYPH_OFFSET[] glyphOffsets);
    }
}
