// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(295,9)
using System;

namespace DirectN
{
    /// <summary>
    /// This specifies options that apply to the device context for its lifetime.
    /// </summary>
    [Flags]
    public enum D2D1_DEVICE_CONTEXT_OPTIONS
    {
        D2D1_DEVICE_CONTEXT_OPTIONS_NONE = 0x00000000,
        
        /// <summary>
        /// Geometry rendering will be performed on many threads in parallel, a single thread is the default.
        /// </summary>
        D2D1_DEVICE_CONTEXT_OPTIONS_ENABLE_MULTITHREADED_OPTIMIZATIONS = 0x00000001,
        
        /// <summary>
        /// Geometry rendering will be performed on many threads in parallel, a single thread is the default.
        /// </summary>
        D2D1_DEVICE_CONTEXT_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
