// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(351,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D2D1_SPRITE_OPTIONS
    {
        /// <summary>
        /// Use default sprite rendering behavior.
        /// </summary>
        D2D1_SPRITE_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// Bitmap interpolation will be clamped to the sprite's source rectangle.
        /// </summary>
        D2D1_SPRITE_OPTIONS_CLAMP_TO_SOURCE_RECTANGLE = 0x00000001,
        
        /// <summary>
        /// Bitmap interpolation will be clamped to the sprite's source rectangle.
        /// </summary>
        D2D1_SPRITE_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
