using System;

namespace DirectN
{
    [Flags]
    public enum TextHostOptions
    {
        None = 0x0,
        WordWrap = 0x1,
        Vertical = 0x2,
        Multiline = 0x4,
    }
}
