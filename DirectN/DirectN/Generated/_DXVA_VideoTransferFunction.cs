// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1872,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_VideoTransferFunction
    {
        DXVA_VideoTransFuncShift = 0x0000001B,
        DXVA_VideoTransFuncMask = unchecked((int)0xF8000000),
        DXVA_VideoTransFunc_Unknown = 0x00000000,
        DXVA_VideoTransFunc_10 = 0x00000001,
        DXVA_VideoTransFunc_18 = 0x00000002,
        DXVA_VideoTransFunc_20 = 0x00000003,
        DXVA_VideoTransFunc_22 = 0x00000004,
        DXVA_VideoTransFunc_22_709 = 0x00000005,
        DXVA_VideoTransFunc_22_240M = 0x00000006,
        DXVA_VideoTransFunc_22_8bit_sRGB = 0x00000007,
        DXVA_VideoTransFunc_28 = 0x00000008,
    }
}
