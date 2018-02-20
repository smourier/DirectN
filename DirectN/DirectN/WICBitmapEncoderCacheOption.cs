using System;

namespace DirectN
{
    [Flags]
    public enum WICBitmapEncoderCacheOption
    {
        WICBitmapEncoderCacheInMemory = 0x00000000,
        WICBitmapEncoderCacheTempFile = 0x00000001,
        WICBitmapEncoderNoCache = 0x00000002
    }
}
