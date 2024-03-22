// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Encapsulates a bitmap which can be used for rendering glyphs.
    /// </summary>
    [ComImport, Guid("aeec37db-c337-40f1-8e2a-9a41b167b238"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteBitmapRenderTarget3 : IDWriteBitmapRenderTarget2
    {
        // IDWriteBitmapRenderTarget
        [PreserveSig]
        new HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ IDWriteRenderingParams renderingParams, uint textColor, /* optional(tagRECT) */ IntPtr blackBoxRect);
        
        [PreserveSig]
        new IntPtr GetMemoryDC();
        
        [PreserveSig]
        new float GetPixelsPerDip();
        
        [PreserveSig]
        new HRESULT SetPixelsPerDip(float pixelsPerDip);
        
        [PreserveSig]
        new HRESULT GetCurrentTransform(/* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        new HRESULT SetCurrentTransform(/* optional(DWRITE_MATRIX) */ IntPtr transform);
        
        [PreserveSig]
        new HRESULT GetSize(/* _Out_ */ out tagSIZE size);
        
        [PreserveSig]
        new HRESULT Resize(uint width, uint height);
        
        // IDWriteBitmapRenderTarget1
        [PreserveSig]
        new DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
        
        [PreserveSig]
        new HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode);
        
        // IDWriteBitmapRenderTarget2
        [PreserveSig]
        new HRESULT GetBitmapData(/* _Out_ */ out DWRITE_BITMAP_DATA_BGRA32 bitmapData);
        
        // IDWriteBitmapRenderTarget3
        [PreserveSig]
        DWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel();
        
        [PreserveSig]
        HRESULT DrawPaintGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, uint textColor, uint colorPaletteIndex, /* optional(tagRECT) */ IntPtr blackBoxRect);
        
        [PreserveSig]
        HRESULT DrawGlyphRunWithColorSupport(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ IDWriteRenderingParams renderingParams, uint textColor, uint colorPaletteIndex, /* optional(tagRECT) */ IntPtr blackBoxRect);
    }
}
