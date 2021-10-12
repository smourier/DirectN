// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1888,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_VideoPrimaries
    {
        DXVA_VideoPrimariesShift = 0x00000016,
        DXVA_VideoPrimariesMask = 0x07C00000,
        DXVA_VideoPrimaries_Unknown = 0x00000000,
        DXVA_VideoPrimaries_reserved = 0x00000001,
        DXVA_VideoPrimaries_BT709 = 0x00000002,
        DXVA_VideoPrimaries_BT470_2_SysM = 0x00000003,
        DXVA_VideoPrimaries_BT470_2_SysBG = 0x00000004,
        DXVA_VideoPrimaries_SMPTE170M = 0x00000005,
        DXVA_VideoPrimaries_SMPTE240M = 0x00000006,
        DXVA_VideoPrimaries_EBU3213 = 0x00000007,
        DXVA_VideoPrimaries_SMPTE_C = 0x00000008,
    }
}
