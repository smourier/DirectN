// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(1043,1)
using System;
using System.Runtime.InteropServices;
using IDWriteGeometrySink = DirectN.ID2D1SimplifiedGeometrySink;

namespace DirectN
{
    /// <summary>
    /// This interface exposes various font data such as metrics, names, and glyph outlines. It contains font face type, appropriate file references and face identification data.
    /// </summary>
    [ComImport, Guid("5f49804d-7024-4d43-bfa9-d25984f53849"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFace
    {
        [PreserveSig]
        DWRITE_FONT_FACE_TYPE GetType();
        
        [PreserveSig]
        HRESULT GetFiles(/* _Inout_ */ ref uint numberOfFiles, /* optional(IDWriteFontFile) */ out IntPtr fontFiles);
        
        [PreserveSig]
        uint GetIndex();
        
        [PreserveSig]
        DWRITE_FONT_SIMULATIONS GetSimulations();
        
        [PreserveSig]
        bool IsSymbolFont();
        
        [PreserveSig]
        void GetMetrics(/* _Out_ */ out DWRITE_FONT_METRICS fontFaceMetrics);
        
        [PreserveSig]
        ushort GetGlyphCount();
        
        [PreserveSig]
        HRESULT GetDesignGlyphMetrics(/* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, int glyphCount, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_GLYPH_METRICS[] glyphMetrics, bool isSideways);
        
        [PreserveSig]
        HRESULT GetGlyphIndicesW(/* _In_reads_(codePointCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] codePoints, int codePointCount, /* _Out_writes_(codePointCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices);
        
        [PreserveSig]
        HRESULT TryGetFontTable(/* _In_ */ uint openTypeTableTag, /* _Outptr_result_bytebuffer_(*tableSize) */ out IntPtr tableData, /* _Out_ */ out uint tableSize, /* _Out_ */ out IntPtr tableContext, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        void ReleaseFontTable(/* _In_ */ IntPtr tableContext);
        
        [PreserveSig]
        HRESULT GetGlyphRunOutline(float emSize, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ushort[] glyphIndices, /* _In_reads_opt_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] float[] glyphAdvances, /* _In_reads_opt_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] DWRITE_GLYPH_OFFSET[] glyphOffsets, int glyphCount, bool isSideways, bool isRightToLeft, /* _In_ */ IDWriteGeometrySink geometrySink);
        
        [PreserveSig]
        HRESULT GetRecommendedRenderingMode(float emSize, float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE renderingMode);
        
        [PreserveSig]
        HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, /* _Out_ */ out DWRITE_FONT_METRICS fontFaceMetrics);
        
        [PreserveSig]
        HRESULT GetGdiCompatibleGlyphMetrics(float emSize, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, /* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] ushort[] glyphIndices, int glyphCount, /* _Out_writes_(glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] DWRITE_GLYPH_METRICS[] glyphMetrics, bool isSideways);
    }
}
