using System;

namespace DirectN
{
    [Flags]
    public enum WICDecodeOptions
    {
        WICDecodeMetadataCacheOnDemand = 0x00000000,
        WICDecodeMetadataCacheOnLoad = 0x00000001
    }
}
