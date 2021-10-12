// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(209,9)
using System;

namespace DirectN
{
    /// <summary>
    /// This describes how the individual mapping operation should be performed.
    /// </summary>
    [Flags]
    public enum D2D1_MAP_OPTIONS
    {
        /// <summary>
        /// The mapped pointer has undefined behavior.
        /// </summary>
        D2D1_MAP_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// The mapped pointer can be read from.
        /// </summary>
        D2D1_MAP_OPTIONS_READ = 0x00000001,
        
        /// <summary>
        /// The mapped pointer can be written to.
        /// </summary>
        D2D1_MAP_OPTIONS_WRITE = 0x00000002,
        
        /// <summary>
        /// The previous contents of the bitmap are discarded when it is mapped.
        /// </summary>
        D2D1_MAP_OPTIONS_DISCARD = 0x00000004,
        
        /// <summary>
        /// The previous contents of the bitmap are discarded when it is mapped.
        /// </summary>
        D2D1_MAP_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
