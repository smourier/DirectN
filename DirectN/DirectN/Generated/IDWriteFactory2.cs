// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(852,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all DWrite objects.
    /// </summary>
    [Guid("0439fc60-ca44-4994-8dee-3a9af7b732ec"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory2
    {
        [PreserveSig]
        HRESULT GetSystemFontFallback(/* _COM_Outptr_ */ out IDWriteFontFallback fontFallback);
        
        [PreserveSig]
        HRESULT CreateFontFallbackBuilder(/* _COM_Outptr_ */ out IDWriteFontFallbackBuilder fontFallbackBuilder);
        
        [PreserveSig]
        HRESULT TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_GLYPH_RUN_DESCRIPTION) */ IntPtr glyphRunDescription, DWRITE_MEASURING_MODE measuringMode, /* optional(DWRITE_MATRIX) */ IntPtr worldToDeviceTransform, uint colorPaletteIndex, /* _COM_Outptr_ */ out IDWriteColorGlyphRunEnumerator colorLayers);
        
        [PreserveSig]
        HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, /* _COM_Outptr_ */ out IDWriteRenderingParams2 renderingParams);
        
        [PreserveSig]
        HRESULT CreateGlyphRunAnalysis(/* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_MATRIX) */ IntPtr transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, /* _COM_Outptr_ */ out IDWriteGlyphRunAnalysis glyphRunAnalysis);
    }
}
