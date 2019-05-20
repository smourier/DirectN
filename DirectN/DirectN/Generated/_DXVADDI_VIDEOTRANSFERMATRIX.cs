// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(1017,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVADDI_VIDEOTRANSFERMATRIX
    {
        DXVADDI_VideoTransferMatrixMask = 0x00000007,
        DXVADDI_VideoTransferMatrix_Unknown = 0x00000000,
        DXVADDI_VideoTransferMatrix_BT709 = 0x00000001,
        DXVADDI_VideoTransferMatrix_BT601 = 0x00000002,
        DXVADDI_VideoTransferMatrix_SMPTE240M = 0x00000003,
    }
}
