using System;

namespace DirectN
{
    [Flags]
    public enum WICMetadataCreationOptions
    {
        WICMetadataCreationDefault = 0x00000000,
        WICMetadataCreationAllowUnknown = WICMetadataCreationDefault,
        WICMetadataCreationFailUnknown = 0x00010000,
        WICMetadataCreationMask = unchecked((int)0xFFFF0000)
    }
}
