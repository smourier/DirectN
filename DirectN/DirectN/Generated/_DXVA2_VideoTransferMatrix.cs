// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva2api.h(255,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_VideoTransferMatrix
    {
        DXVA2_VideoTransferMatrixMask = 0x00000007,
        DXVA2_VideoTransferMatrix_Unknown = 0x00000000,
        DXVA2_VideoTransferMatrix_BT709 = 0x00000001,
        DXVA2_VideoTransferMatrix_BT601 = 0x00000002,
        DXVA2_VideoTransferMatrix_SMPTE240M = 0x00000003,
    }
}
