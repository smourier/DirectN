// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(68,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Option flags controlling how images sources are loaded during CreateImageSourceFromWic.
    /// </summary>
    [Flags]
    public enum D2D1_IMAGE_SOURCE_LOADING_OPTIONS
    {
        D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE = 0x00000000,
        D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE = 0x00000001,
        D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND = 0x00000002,
        D2D1_IMAGE_SOURCE_LOADING_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
