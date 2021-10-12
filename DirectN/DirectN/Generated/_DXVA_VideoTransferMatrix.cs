// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1916,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_VideoTransferMatrix
    {
        DXVA_VideoTransferMatrixShift = 0x0000000F,
        DXVA_VideoTransferMatrixMask = 0x00038000,
        DXVA_VideoTransferMatrix_Unknown = 0x00000000,
        DXVA_VideoTransferMatrix_BT709 = 0x00000001,
        DXVA_VideoTransferMatrix_BT601 = 0x00000002,
        DXVA_VideoTransferMatrix_SMPTE240M = 0x00000003,
    }
}
