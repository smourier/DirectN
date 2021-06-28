// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(345,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents text rendering settings for glyph rasterization and filtering.
    /// </summary>
    [ComImport, Guid("b7924baa-391b-412a-8c5c-e44cc2d867dc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRenderingParams3 : IDWriteRenderingParams2
    {
        // IDWriteRenderingParams
        [PreserveSig]
        new float GetGamma();
        
        [PreserveSig]
        new float GetEnhancedContrast();
        
        [PreserveSig]
        new float GetClearTypeLevel();
        
        [PreserveSig]
        new DWRITE_PIXEL_GEOMETRY GetPixelGeometry();
        
        [PreserveSig]
        new DWRITE_RENDERING_MODE GetRenderingMode();
        
        // IDWriteRenderingParams1
        [PreserveSig]
        new float GetGrayscaleEnhancedContrast();
        
        // IDWriteRenderingParams2
        [PreserveSig]
        new DWRITE_GRID_FIT_MODE GetGridFitMode();
        
        // IDWriteRenderingParams3
        [PreserveSig]
        DWRITE_RENDERING_MODE1 GetRenderingMode1();
    }
}
