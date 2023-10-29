using System;

namespace DirectN
{
    [Flags]
    public enum DWM_BB
    {
        DWM_BB_ENABLE = 0x00000001,
        DWM_BB_BLURREGION = 0x00000002,
        DWM_BB_TRANSITIONONMAXIMIZED = 0x00000004,
    }
}
