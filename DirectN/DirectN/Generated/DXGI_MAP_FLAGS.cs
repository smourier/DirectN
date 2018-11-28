using System;

namespace DirectN
{
    [Flags]
    public enum DXGI_MAP_FLAGS
    {
        DXGI_MAP_READ = 1,
        DXGI_MAP_WRITE = 2,
        DXGI_MAP_DISCARD = 4
    }
}
