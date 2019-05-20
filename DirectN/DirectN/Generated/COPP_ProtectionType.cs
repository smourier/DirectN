// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva9typ.h(809,1)
using System;

namespace DirectN
{
    [Flags]
    public enum COPP_ProtectionType
    {
        COPP_ProtectionType_Unknown = unchecked((int)0x80000000),
        COPP_ProtectionType_None = 0x00000000,
        COPP_ProtectionType_HDCP = 0x00000001,
        COPP_ProtectionType_ACP = 0x00000002,
        COPP_ProtectionType_CGMSA = 0x00000004,
        COPP_ProtectionType_Mask = unchecked((int)0x80000007),
        COPP_ProtectionType_Reserved = 0x7FFFFFF8,
    }
}
