// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva2api.h(291,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_VideoTransferFunction
    {
        DXVA2_VideoTransFuncMask = 0x0000001F,
        DXVA2_VideoTransFunc_Unknown = 0x00000000,
        DXVA2_VideoTransFunc_10 = 0x00000001,
        DXVA2_VideoTransFunc_18 = 0x00000002,
        DXVA2_VideoTransFunc_20 = 0x00000003,
        DXVA2_VideoTransFunc_22 = 0x00000004,
        DXVA2_VideoTransFunc_709 = 0x00000005,
        DXVA2_VideoTransFunc_240M = 0x00000006,
        DXVA2_VideoTransFunc_sRGB = 0x00000007,
        DXVA2_VideoTransFunc_28 = 0x00000008,
    }
}
