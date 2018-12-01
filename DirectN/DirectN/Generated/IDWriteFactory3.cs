// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(357,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all DWrite objects.
    /// </summary>
    [Guid("9a1b41c3-d3bb-466a-87fc-fe67556a3b65"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory3
    {
        [PreserveSig]
        HRESULT CreateGlyphRunAnalysis(/* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_opt_ */ ref DWRITE_MATRIX transform, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_MEASURING_MODE measuringMode, DWRITE_GRID_FIT_MODE gridFitMode, DWRITE_TEXT_ANTIALIAS_MODE antialiasMode, float baselineOriginX, float baselineOriginY, /* _COM_Outptr_ */ out IDWriteGlyphRunAnalysis glyphRunAnalysis);
        
        [PreserveSig]
        HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float grayscaleEnhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE1 renderingMode, DWRITE_GRID_FIT_MODE gridFitMode, /* _COM_Outptr_ */ out IDWriteRenderingParams3 renderingParams);
        
        [PreserveSig]
        HRESULT CreateFontFaceReference(/* _In_z_ */ ref char filePath, /* _In_opt_ */ ref _FILETIME lastWriteTime, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        HRESULT CreateFontFaceReference(/* _In_ */ ref IDWriteFontFile fontFile, uint faceIndex, DWRITE_FONT_SIMULATIONS fontSimulations, /* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        HRESULT GetSystemFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        [PreserveSig]
        HRESULT CreateFontSetBuilder(/* _COM_Outptr_ */ out IDWriteFontSetBuilder fontSetBuilder);
        
        [PreserveSig]
        HRESULT CreateFontCollectionFromFontSet(IDWriteFontSet fontSet, /* _COM_Outptr_ */ out IDWriteFontCollection1 fontCollection);
        
        [PreserveSig]
        HRESULT GetSystemFontCollection(bool includeDownloadableFonts, /* _COM_Outptr_ */ out IDWriteFontCollection1 fontCollection, bool checkForUpdates);
        
        [PreserveSig]
        HRESULT GetFontDownloadQueue(/* _COM_Outptr_ */ out IDWriteFontDownloadQueue fontDownloadQueue);
    }
}
