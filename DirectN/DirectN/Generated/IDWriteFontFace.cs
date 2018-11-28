using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5f49804d-7024-4d43-bfa9-d25984f53849"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteFontFace
    {
        [PreserveSig]
        DWRITE_FONT_FACE_TYPE GetType();

        [PreserveSig]
        HRESULT GetFiles(ref int numberOfFiles, [In, Out] IDWriteFontFile[] fontFiles);

        [PreserveSig]
        int GetIndex();

        [PreserveSig]
        DWRITE_FONT_SIMULATIONS GetSimulations();

        [PreserveSig]
        bool IsSymbolFont();

        [PreserveSig]
        void GetMetrics(out DWRITE_FONT_METRICS fontFaceMetrics);

        [PreserveSig]
        short GetGlyphCount();

        [PreserveSig]
        HRESULT GetDesignGlyphMetrics(short[] glyphIndices, int glyphCount, [In, Out] DWRITE_GLYPH_METRICS[] glyphMetrics, bool isSideways);

        [PreserveSig]
        HRESULT GetGlyphIndices(int[] codePoints, int codePointCount, [In, Out] short[] glyphIndices);

        [PreserveSig]
        HRESULT TryGetFontTable(uint openTypeTableTag, out IntPtr tableData, out int tableSize, out IntPtr tableContext, out bool exists);

        [PreserveSig]
        void ReleaseFontTable(IntPtr tableContext);

        [PreserveSig]
        HRESULT GetGlyphRunOutline(
            float emSize,
            short[] glyphIndices,
            float[] glyphAdvances,
            DWRITE_GLYPH_OFFSET[] glyphOffsets,
            int glyphCount,
            bool isSideways,
            bool isRightToLeft,
            ID2D1SimplifiedGeometrySink geometrySink
        );

        [PreserveSig]
        HRESULT GetRecommendedRenderingMode(
            float emSize,
            float pixelsPerDip,
            DWRITE_MEASURING_MODE measuringMode,
            IDWriteRenderingParams renderingParams,
            out DWRITE_RENDERING_MODE renderingMode
            );

        [PreserveSig]
        HRESULT GetGdiCompatibleMetrics(float emSize, float pixelsPerDip, ref DWRITE_MATRIX transform, out DWRITE_FONT_METRICS fontFaceMetrics);

        [PreserveSig]
        HRESULT GetGdiCompatibleGlyphMetrics(
            float emSize,
            float pixelsPerDip,
            ref DWRITE_MATRIX transform,
            bool useGdiNatural,
            short[] glyphIndices,
            int glyphCount,
            [In, Out] DWRITE_GLYPH_METRICS[] glyphMetrics,
            bool isSideways
        );
    }
}
