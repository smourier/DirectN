using System;

namespace DirectN
{
    [Flags]
    public enum DXGI_MWA_FLAGS
    {
        DXGI_MWA_NO_WINDOW_CHANGES = (1 << 0),
        DXGI_MWA_NO_ALT_ENTER = (1 << 1),
        DXGI_MWA_NO_PRINT_SCREEN = (1 << 2),
    }
}
