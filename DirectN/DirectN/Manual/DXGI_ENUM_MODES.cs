using System;

namespace DirectN
{
    [Flags]
    public enum DXGI_ENUM_MODES
    {
        DXGI_ENUM_MODES_INTERLACED = 1,
        DXGI_ENUM_MODES_SCALING = 2,
        DXGI_ENUM_MODES_STEREO = 4,
        DXGI_ENUM_MODES_DISABLED_STEREO = 8,
    }
}
