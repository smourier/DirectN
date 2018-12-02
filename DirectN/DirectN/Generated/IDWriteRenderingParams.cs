// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(1003,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2f0da53a-2add-47cd-82ee-d9ec34688e75"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
