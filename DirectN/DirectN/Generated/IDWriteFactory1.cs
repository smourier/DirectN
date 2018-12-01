// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(1018,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all DWrite objects.
    /// </summary>
    [Guid("30572f99-dac6-41db-a16e-0486307e606a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory1
    {
        [PreserveSig]
        HRESULT GetEudcFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, bool checkForUpdates);
        
        [PreserveSig]
        HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, /* _COM_Outptr_ */ out IDWriteRenderingParams1 renderingParams);
    }
}
