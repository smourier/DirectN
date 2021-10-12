// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(836,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Describes how a render target is remoted and whether it should be GDI-compatible. This enumeration allows a bitwise combination of its member values.
    /// </summary>
    [Flags]
    public enum D2D1_RENDER_TARGET_USAGE
    {
        D2D1_RENDER_TARGET_USAGE_NONE = 0x00000000,
        
        /// <summary>
        /// Rendering will occur locally, if a terminal-services session is established, the bitmap updates will be sent to the terminal services client.
        /// </summary>
        D2D1_RENDER_TARGET_USAGE_FORCE_BITMAP_REMOTING = 0x00000001,
        
        /// <summary>
        /// The render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget interface. Rendering will also occur locally.
        /// </summary>
        D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE = 0x00000002,
        
        /// <summary>
        /// The render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget interface. Rendering will also occur locally.
        /// </summary>
        D2D1_RENDER_TARGET_USAGE_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
