using System;

namespace DirectN
{
    [Flags]
    public enum ColorProfileFlags
    {
        FLAG_NONE = 0x00000000,
        FLAG_EMBEDDEDPROFILE = 0x00000001,
        FLAG_DEPENDENTONDATA = 0x00000002,
    }
}
