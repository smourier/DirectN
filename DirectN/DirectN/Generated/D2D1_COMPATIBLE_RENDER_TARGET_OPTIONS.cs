// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(915,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Specifies additional features supportable by a compatible render target when it is created. This enumeration allows a bitwise combination of its member values.
    /// </summary>
    [Flags]
    public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS
    {
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// The compatible render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget interface. This can be specified even if the parent render target is not GDI compatible.
        /// </summary>
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE = 0x00000001,
        
        /// <summary>
        /// The compatible render target will allow a call to GetDC on the ID2D1GdiInteropRenderTarget interface. This can be specified even if the parent render target is not GDI compatible.
        /// </summary>
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
