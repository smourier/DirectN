using System;

namespace DirectN
{
    [Flags]
    public enum EDS
    {
        EDS_NONE = 0,
        EDS_RAWMODE = 0x2,
        EDS_ROTATEDMODE = 0x4,
    }
}
