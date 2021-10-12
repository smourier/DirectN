// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(98,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Option flags for transformed image sources.
    /// </summary>
    [Flags]
    public enum D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS
    {
        D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// Prevents the image source from being automatically scaled (by a ratio of the context DPI divided by 96) while drawn.
        /// </summary>
        D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_DISABLE_DPI_SCALE = 0x00000001,
        
        /// <summary>
        /// Prevents the image source from being automatically scaled (by a ratio of the context DPI divided by 96) while drawn.
        /// </summary>
        D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
