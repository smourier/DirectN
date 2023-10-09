using System;

namespace DirectN
{
    [Flags]
    public enum WDA
    {
        WDA_NONE = 0,
        WDA_MONITOR = 0x00000001,
        WDA_EXCLUDEFROMCAPTURE = 0x00000011,
    }
}
