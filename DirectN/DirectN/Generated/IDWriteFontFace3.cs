// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1154,1)
using System;
using System.Runtime.InteropServices;
using IDWriteGeometrySink = DirectN.ID2D1SimplifiedGeometrySink;

namespace DirectN
{
    /// <summary>
    /// The interface that represents an absolute reference to a font face. It contains font face type, appropriate file references and face identification data. Various font data such as metrics, names and glyph outlines is obtained from IDWriteFontFace.
    /// </summary>
    [ComImport, Guid("d37d7598-09be-4222-a236-2081341cc1f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFace3 : IDWriteFontFace2
    {
        // IDWriteFontFace
        [PreserveSig]
        new DWRITE_FONT_FACE_TYPE GetType();
        
        [PreserveSig]
        new HRESULT GetFiles(/* _Inout_ */ ref uint numberOfFiles, /* optional(IDWriteFontFile) */ out IntPtr fontFiles);
        
        [PreserveSig]
        new uint GetIndex();
        
        [PreserveSig]
        new DWRITE_FONT_SIMULATIONS GetSimulations();
        
        [PreserveSig]
        new bool IsSymbolFont();
        
        [PreserveSig]
        new void GetMetrics(/* _Out_ */ out DWRITE_FONT_METRICS fontFaceMetrics);
        
        [PreserveSig]
        new ushort GetGlyphCount();
        
        [PreserveSig]
        new HRESULT GetDesignGlyphMetrics(/* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, int glyphCount, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_GLYPH_METRICS[] glyphMetrics, bool isSideways);
        
        [PreserveSig]
        new HRESULT GetGlyphIndicesW(/* _In_reads_(codePointCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] codePoints, int codePointCount, /* _Out_writes_(codePointCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices);
        
        [PreserveSig]
        new HRESULT TryGetFontTable(/* _In_ */ uint openTypeTableTag, /* _Outptr_result_bytebuffer_(*tableSize) */ out IntPtr tableData, /* _Out_ */ out uint tableSize, /* _Out_ */ out IntPtr tableContext, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new void ReleaseFontTable(/* _In_ */ IntPtr tableContext);
        
        [PreserveSig]
        new HRESULT GetGlyphRunOutline(float emSize, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ushort[] glyphIndices, /* _In_reads_opt_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] glyphAdvances, /* _In_reads_opt_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] glyphOffsets, int glyphCount, bool isSideways, bool isRightToLeft, /* _In_ */ IDWriteGeometrySink geometrySink);
        
        [PreserveSig]
        new HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE renderingMode);
        
        [PreserveSig]
        new HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, /* _Out_ */ out DWRITE_FONT_METRICS fontFaceMetrics);
        
        [PreserveSig]
        new HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] ushort[] glyphIndices, int glyphCount, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_GLYPH_METRICS[] glyphMetrics, bool isSideways);
        
        // IDWriteFontFace1
        [PreserveSig]
        new void GetMetrics(/* _Out_ */ out DWRITE_FONT_METRICS1 fontMetrics);
        
        [PreserveSig]
        new HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, /* _Out_ */ out DWRITE_FONT_METRICS1 fontMetrics);
        
        [PreserveSig]
        new void GetCaretMetrics(/* _Out_ */ out DWRITE_CARET_METRICS caretMetrics);
        
        [PreserveSig]
        new HRESULT GetUnicodeRanges(int maxRangeCount, /* _Out_writes_to_opt_(maxRangeCount, *actualRangeCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] DWRITE_UNICODE_RANGE[] unicodeRanges, /* _Out_ */ out uint actualRangeCount);
        
        [PreserveSig]
        new bool IsMonospacedFont();
        
        [PreserveSig]
        new HRESULT GetDesignGlyphAdvances(int glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ushort[] glyphIndices, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] int[] glyphAdvances, bool isSideways);
        
        [PreserveSig]
        new HRESULT GetGdiCompatibleGlyphAdvances(float emSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, bool isSideways, int glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] ushort[] glyphIndices, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] int[] glyphAdvances);
        
        [PreserveSig]
        new HRESULT GetKerningPairAdjustments(int glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ushort[] glyphIndices, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] int[] glyphAdvanceAdjustments);
        
        [PreserveSig]
        new bool HasKerningPairs();
        
        [PreserveSig]
        new HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* _Out_ */ out DWRITE_RENDERING_MODE renderingMode);
        
        [PreserveSig]
        new HRESULT GetVerticalGlyphVariants(int glyphCount, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ushort[] nominalGlyphIndices, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ushort[] verticalGlyphIndices);
        
        [PreserveSig]
        new bool HasVerticalGlyphVariants();
        
        // IDWriteFontFace2
        [PreserveSig]
        new bool IsColorFont();
        
        [PreserveSig]
        new uint GetColorPaletteCount();
        
        [PreserveSig]
        new uint GetPaletteEntryCount();
        
        [PreserveSig]
        new HRESULT GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, int entryCount, /* _Out_writes_(entryCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _D3DCOLORVALUE[] paletteEntries);
        
        [PreserveSig]
        new HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* _In_opt_ */ IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE renderingMode, /* _Out_ */ out DWRITE_GRID_FIT_MODE gridFitMode);
        
        // IDWriteFontFace3
        [PreserveSig]
        HRESULT GetFontFaceReference(/* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        void GetPanose(/* _Out_ */ out DWRITE_PANOSE panose);
        
        [PreserveSig]
        DWRITE_FONT_WEIGHT GetWeight();
        
        [PreserveSig]
        DWRITE_FONT_STRETCH GetStretch();
        
        [PreserveSig]
        DWRITE_FONT_STYLE GetStyle();
        
        [PreserveSig]
        HRESULT GetFamilyNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        HRESULT GetFaceNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings informationalStrings, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        bool HasCharacter(uint unicodeValue);
        
        [PreserveSig]
        HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* _In_opt_ */ IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE1 renderingMode, /* _Out_ */ out DWRITE_GRID_FIT_MODE gridFitMode);
        
        [PreserveSig]
        bool IsCharacterLocal(uint unicodeValue);
        
        [PreserveSig]
        bool IsGlyphLocal(ushort glyphId);
        
        [PreserveSig]
        HRESULT AreCharactersLocal(/* _In_reads_(characterCount) */ [MarshalAs(UnmanagedType.LPWStr)] string characters, uint characterCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
        
        [PreserveSig]
        HRESULT AreGlyphsLocal(/* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, int glyphCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
    }
}
