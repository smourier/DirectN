// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodecsdk.h(258,1)
using System;

namespace DirectN
{
    [Flags]
    public enum WICMetadataCreationOptions
    {
        WICMetadataCreationDefault = 0x00000000,
        WICMetadataCreationAllowUnknown = 0x00000000,
        WICMetadataCreationFailUnknown = 0x00010000,
        WICMetadataCreationMask = unchecked((int)0xFFFF0000),
    }
}
