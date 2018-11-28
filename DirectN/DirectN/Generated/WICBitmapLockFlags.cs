using System;

namespace DirectN
{
    [Flags]
    public enum WICBitmapLockFlags
    {
        WICBitmapLockRead = 0x00000001,
        WICBitmapLockWrite = 0x00000002
    }
}
