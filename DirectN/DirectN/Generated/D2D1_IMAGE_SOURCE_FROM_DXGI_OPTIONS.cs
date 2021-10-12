// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(84,9)
using System;

namespace DirectN
{
    /// <summary>
    /// Option flags controlling primary conversion performed by CreateImageSourceFromDxgi, if any.
    /// </summary>
    [Flags]
    public enum D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS
    {
        D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_NONE = 0x00000000,
        D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_LOW_QUALITY_PRIMARY_CONVERSION = 0x00000001,
        D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
