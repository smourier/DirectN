// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(112,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Indicates options for drawing custom vertices set by transforms.
    /// </summary>
    [Flags]
    public enum D2D1_VERTEX_OPTIONS
    {
        /// <summary>
        /// Default vertex processing.
        /// </summary>
        D2D1_VERTEX_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// Indicates that the output rectangle does not need to be cleared before drawing custom vertices. This must only be used by transforms whose custom vertices completely cover their output rectangle.
        /// </summary>
        D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR = 0x00000001,
        
        /// <summary>
        /// Causes a depth buffer to be used while drawing custom vertices. This impacts drawing behavior when primitives overlap one another.
        /// </summary>
        D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER = 0x00000002,
        
        /// <summary>
        /// Indicates that custom vertices do not form primitives which overlap one another.
        /// </summary>
        D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP = 0x00000004,
        
        /// <summary>
        /// Indicates that custom vertices do not form primitives which overlap one another.
        /// </summary>
        D2D1_VERTEX_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
