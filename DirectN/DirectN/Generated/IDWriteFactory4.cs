// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1962,1)
using System;
using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;
using FILETIME = DirectN._FILETIME;

namespace DirectN
{
    [Guid("4b0b5bd3-0797-4549-8ac5-fe915cc53856"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory4 : IDWriteFactory3
    {
        // IDWriteFactory3
        [PreserveSig]
        new HRESULT CreateGlyphRunAnalysis(/* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_MATRIX) */ IntPtr transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, /* _COM_Outptr_ */ out IDWriteGlyphRunAnalysis glyphRunAnalysis);
        
        [PreserveSig]
        new HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, /* _COM_Outptr_ */ out IDWriteRenderingParams3 renderingParams);
        
        [PreserveSig]
        new HRESULT CreateFontFaceReference(/* _In_z_ */ ref char filePath, /* optional(FILETIME) */ IntPtr lastWriteTime, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new HRESULT CreateFontFaceReference(/* _In_ */ ref IDWriteFontFile fontFile, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new HRESULT GetSystemFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        [PreserveSig]
        new HRESULT CreateFontSetBuilder(/* _COM_Outptr_ */ out IDWriteFontSetBuilder fontSetBuilder);
        
        [PreserveSig]
        new HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet fontSet, /* _COM_Outptr_ */ out IDWriteFontCollection1 fontCollection);
        
        [PreserveSig]
        new HRESULT GetSystemFontCollection(bool includeDownloadableFonts, /* _COM_Outptr_ */ out IDWriteFontCollection1 fontCollection, bool checkForUpdates);
        
        [PreserveSig]
        new HRESULT GetFontDownloadQueue(/* _COM_Outptr_ */ out IDWriteFontDownloadQueue fontDownloadQueue);
        
        // IDWriteFactory4
        [PreserveSig]
        HRESULT TranslateColorGlyphRun(D2D1_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_GLYPH_RUN_DESCRIPTION) */ IntPtr glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, /* optional(DWRITE_MATRIX) */ IntPtr worldAndDpiTransform, uint colorPaletteIndex, /* _COM_Outptr_ */ out IDWriteColorGlyphRunEnumerator1 colorLayers);
        
        [PreserveSig]
        HRESULT ComputeGlyphOrigins(ref DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, D2D1_POINT_2F baselineOrigin, /* optional(DWRITE_MATRIX) */ IntPtr worldAndDpiTransform, /* _Out_writes_(glyphRun->glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray)] D2D1_POINT_2F[] glyphOrigins);
        
        [PreserveSig]
        HRESULT ComputeGlyphOrigins(ref DWRITE_GLYPH_RUN glyphRun, D2D1_POINT_2F baselineOrigin, /* _Out_writes_(glyphRun->glyphCount) */ [Out, MarshalAs(UnmanagedType.LPArray)] D2D1_POINT_2F[] glyphOrigins);
    }
}
