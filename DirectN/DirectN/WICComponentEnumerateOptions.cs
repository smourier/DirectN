using System;

namespace DirectN
{
    [Flags]
    public enum WICComponentEnumerateOptions
    {
        WICComponentEnumerateDefault = 0x00000000,
        WICComponentEnumerateRefresh = 0x00000001,
        WICComponentEnumerateDisabled = unchecked((int)0x80000000),
        WICComponentEnumerateUnsigned = 0x40000000,
        WICComponentEnumerateBuiltInOnly = 0x20000000
    }
}
