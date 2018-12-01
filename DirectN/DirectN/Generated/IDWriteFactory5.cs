// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(2313,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all DWrite objects.
    /// </summary>
    [Guid("958db99a-be2a-4f09-af7d-65189803d1d3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory5 : IDWriteFactory4
    {
        // IDWriteFactory3
        [PreserveSig]
        new HRESULT CreateGlyphRunAnalysis(/* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_opt_ */ ref DWRITE_MATRIX transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, /* _COM_Outptr_ */ out IDWriteGlyphRunAnalysis glyphRunAnalysis);
        
        [PreserveSig]
        new HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, /* _COM_Outptr_ */ out IDWriteRenderingParams3 renderingParams);
        
        [PreserveSig]
        new HRESULT CreateFontFaceReference(/* _In_z_ */ ref char filePath, /* _In_opt_ */ ref _FILETIME lastWriteTime, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
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
        new HRESULT TranslateColorGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_opt_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, DWRITE_GLYPH_IMAGE_FORMATS desiredGlyphImageFormats, DWRITE_MEASURING_MODE measuringMode, /* _In_opt_ */ ref DWRITE_MATRIX worldAndDpiTransform, uint colorPaletteIndex, /* _COM_Outptr_ */ out IDWriteColorGlyphRunEnumerator1 colorLayers);
        
        [PreserveSig]
        new HRESULT ComputeGlyphOrigins(ref DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, D2D_POINT_2F baselineOrigin, /* _In_opt_ */ ref DWRITE_MATRIX worldAndDpiTransform, /* _Out_writes_(glyphRun->glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_POINT_2F[] glyphOrigins);
        
        [PreserveSig]
        new HRESULT ComputeGlyphOrigins(ref DWRITE_GLYPH_RUN glyphRun, D2D_POINT_2F baselineOrigin, /* _Out_writes_(glyphRun->glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D2D_POINT_2F[] glyphOrigins);
        
        // IDWriteFactory5
        [PreserveSig]
        HRESULT CreateFontSetBuilder(/* _COM_Outptr_ */ out IDWriteFontSetBuilder1 fontSetBuilder);
        
        [PreserveSig]
        HRESULT CreateInMemoryFontFileLoader(/* _COM_Outptr_ */ out IDWriteInMemoryFontFileLoader newLoader);
        
        [PreserveSig]
        HRESULT CreateHttpFontFileLoader(/* _In_opt_z_ */ ref char referrerUrl, /* _In_opt_z_ */ ref char extraHeaders, /* _COM_Outptr_ */ out IDWriteRemoteFontFileLoader newLoader);
        
        [PreserveSig]
        DWRITE_CONTAINER_TYPE AnalyzeContainerType(/* _In_reads_bytes_(fileDataSize) */ out IntPtr fileData, uint fileDataSize);
        
        [PreserveSig]
        HRESULT UnpackFontFile(DWRITE_CONTAINER_TYPE containerType, /* _In_reads_bytes_(fileDataSize) */ out IntPtr fileData, uint fileDataSize, /* _COM_Outptr_ */ out IDWriteFontFileStream unpackedFontStream);
    }
}
