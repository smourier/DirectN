// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(1647,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_NominalRange
    {
        DXVA_NominalRangeShift = 0x0000000C,
        DXVA_NominalRangeMask = 0x00007000,
        DXVA_NominalRange_Unknown = 0x00000000,
        DXVA_NominalRange_Normal = 0x00000001,
        DXVA_NominalRange_Wide = 0x00000002,
        DXVA_NominalRange_0_255 = 0x00000001,
        DXVA_NominalRange_16_235 = 0x00000002,
        DXVA_NominalRange_48_208 = 0x00000003,
    }
}
