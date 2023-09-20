// generated from <Windows SDK Path>\um\dwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents text rendering settings for glyph rasterization and filtering.
    /// </summary>
    [ComImport, Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRenderingParams
    {
        [PreserveSig]
        float GetGamma();
        
        [PreserveSig]
        float GetEnhancedContrast();
        
        [PreserveSig]
        float GetClearTypeLevel();
        
        [PreserveSig]
        DWRITE_PIXEL_GEOMETRY GetPixelGeometry();
        
        [PreserveSig]
        DWRITE_RENDERING_MODE GetRenderingMode();
    }
}
