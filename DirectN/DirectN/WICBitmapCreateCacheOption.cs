using System;

namespace DirectN
{
    [Flags]
    public enum WICBitmapCreateCacheOption
    {
        WICBitmapNoCache = 0x00000000,
        WICBitmapCacheOnDemand = 0x00000001,
        WICBitmapCacheOnLoad = 0x00000002
    }
}
