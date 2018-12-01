// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_1.h(1899,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Encapsulates a 32-bit device independent bitmap and device context, which can be used for rendering glyphs.
    /// </summary>
    [Guid("791e8298-3ef3-4230-9880-c9bdecc42064"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteBitmapRenderTarget1
    {
        [PreserveSig]
        DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
        
        [PreserveSig]
        HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode);
    }
}
