// generated from <Windows SDK Path>\um\dxva.h
using System;

namespace DirectN
{
    [Flags]
    public enum _COPP_TVProtectionStandard
    {
        COPP_ProtectionStandard_Unknown = unchecked((int)0x80000000),
        COPP_ProtectionStandard_None = 0x00000000,
        COPP_ProtectionStandard_IEC61880_525i = 0x00000001,
        COPP_ProtectionStandard_IEC61880_2_525i = 0x00000002,
        COPP_ProtectionStandard_IEC62375_625p = 0x00000004,
        COPP_ProtectionStandard_EIA608B_525 = 0x00000008,
        COPP_ProtectionStandard_EN300294_625i = 0x00000010,
        COPP_ProtectionStandard_CEA805A_TypeA_525p = 0x00000020,
        COPP_ProtectionStandard_CEA805A_TypeA_750p = 0x00000040,
        COPP_ProtectionStandard_CEA805A_TypeA_1125i = 0x00000080,
        COPP_ProtectionStandard_CEA805A_TypeB_525p = 0x00000100,
        COPP_ProtectionStandard_CEA805A_TypeB_750p = 0x00000200,
        COPP_ProtectionStandard_CEA805A_TypeB_1125i = 0x00000400,
        COPP_ProtectionStandard_ARIBTRB15_525i = 0x00000800,
        COPP_ProtectionStandard_ARIBTRB15_525p = 0x00001000,
        COPP_ProtectionStandard_ARIBTRB15_750p = 0x00002000,
        COPP_ProtectionStandard_ARIBTRB15_1125i = 0x00004000,
        COPP_ProtectionStandard_Mask = unchecked((int)0x80007FFF),
        COPP_ProtectionStandard_Reserved = 0x7FFF8000,
    }
}
