using System;

namespace DirectN
{
    [Flags]
    public enum WICComponentSigning
    {
        WICComponentSigned = 0x00000001,
        WICComponentUnsigned = 0x00000002,
        WICComponentSafe = 0x00000004,
        WICComponentDisabled = unchecked((int)0x80000000)
    }
}
