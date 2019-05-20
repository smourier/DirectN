// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva2api.h(276,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_VideoPrimaries
    {
        DXVA2_VideoPrimariesMask = 0x0000001F,
        DXVA2_VideoPrimaries_Unknown = 0x00000000,
        DXVA2_VideoPrimaries_reserved = 0x00000001,
        DXVA2_VideoPrimaries_BT709 = 0x00000002,
        DXVA2_VideoPrimaries_BT470_2_SysM = 0x00000003,
        DXVA2_VideoPrimaries_BT470_2_SysBG = 0x00000004,
        DXVA2_VideoPrimaries_SMPTE170M = 0x00000005,
        DXVA2_VideoPrimaries_SMPTE240M = 0x00000006,
        DXVA2_VideoPrimaries_EBU3213 = 0x00000007,
        DXVA2_VideoPrimaries_SMPTE_C = 0x00000008,
    }
}
