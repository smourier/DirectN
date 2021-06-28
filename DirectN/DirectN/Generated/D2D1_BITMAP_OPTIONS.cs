// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(132,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Specifies how the bitmap can be used.
    /// </summary>
    [Flags]
    public enum D2D1_BITMAP_OPTIONS
    {
        /// <summary>
        /// The bitmap is created with default properties.
        /// </summary>
        D2D1_BITMAP_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// The bitmap can be specified as a target in ID2D1DeviceContext::SetTarget
        /// </summary>
        D2D1_BITMAP_OPTIONS_TARGET = 0x00000001,
        
        /// <summary>
        /// The bitmap cannot be used as an input to DrawBitmap, DrawImage, in a bitmap brush or as an input to an effect.
        /// </summary>
        D2D1_BITMAP_OPTIONS_CANNOT_DRAW = 0x00000002,
        
        /// <summary>
        /// The bitmap can be read from the CPU.
        /// </summary>
        D2D1_BITMAP_OPTIONS_CPU_READ = 0x00000004,
        
        /// <summary>
        /// The bitmap works with the ID2D1GdiInteropRenderTarget::GetDC API.
        /// </summary>
        D2D1_BITMAP_OPTIONS_GDI_COMPATIBLE = 0x00000008,
        
        /// <summary>
        /// The bitmap works with the ID2D1GdiInteropRenderTarget::GetDC API.
        /// </summary>
        D2D1_BITMAP_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
