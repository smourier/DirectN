// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(841,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents text rendering settings for glyph rasterization and filtering.
    /// </summary>
    [ComImport, Guid("f9d711c3-9777-40ae-87e8-3e5af9bf0948"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRenderingParams2 : IDWriteRenderingParams1
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
        DWRITE_GRID_FIT_MODE GetGridFitMode();
    }
}
