// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(652,1)
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
        WICComponentEnumerateBuiltInOnly = 0x20000000,
        WICCOMPONENTENUMERATEOPTIONS_FORCE_DWORD = 0x7FFFFFFF,
    }
}
