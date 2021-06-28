// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(88,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Indicates options for drawing using a pixel shader.
    /// </summary>
    [Flags]
    public enum D2D1_PIXEL_OPTIONS
    {
        /// <summary>
        /// Default pixel processing.
        /// </summary>
        D2D1_PIXEL_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// Indicates that the shader samples its inputs only at exactly the same scene coordinate as the output pixel, and that it returns transparent black whenever the input pixels are also transparent black.
        /// </summary>
        D2D1_PIXEL_OPTIONS_TRIVIAL_SAMPLING = 0x00000001,
        
        /// <summary>
        /// Indicates that the shader samples its inputs only at exactly the same scene coordinate as the output pixel, and that it returns transparent black whenever the input pixels are also transparent black.
        /// </summary>
        D2D1_PIXEL_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
