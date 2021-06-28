// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_1.h(1410,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents text rendering settings for glyph rasterization and filtering.
    /// </summary>
    [ComImport, Guid("94413cf4-a6fc-4248-8b50-6674348fcad3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteRenderingParams1 : IDWriteRenderingParams
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
        float GetGrayscaleEnhancedContrast();
    }
}
