using System;

namespace DirectN
{
    [Flags]
    public enum DWM_CLOAKED
    {
        DWM_CLOAKED_NONE = 0,
        DWM_CLOAKED_APP = 0x1,
        DWM_CLOAKED_SHELL = 0x2,
        DWM_CLOAKED_INHERITED = 0x4,
    }
}
