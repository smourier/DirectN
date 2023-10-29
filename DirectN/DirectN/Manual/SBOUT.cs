using System;

namespace DirectN
{
    [Flags]
    public enum SBOUT
    {
        ES_AUTOVSCROLL = 0x0040,
        ES_AUTOHSCROLL = 0x0080,
        ES_DISABLENOSCROLL = 0x00002000,
        WS_HSCROLL = 0x00100000,
        WS_VSCROLL = 0x00200000,
    }
}
