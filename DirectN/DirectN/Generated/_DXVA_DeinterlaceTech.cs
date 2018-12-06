// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(443,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_DeinterlaceTech
    {
        DXVA_DeinterlaceTech_Unknown = 0x00000000,
        DXVA_DeinterlaceTech_BOBLineReplicate = 0x00000001,
        DXVA_DeinterlaceTech_BOBVerticalStretch = 0x00000002,
        DXVA_DeinterlaceTech_BOBVerticalStretch4Tap = 0x00000100,
        DXVA_DeinterlaceTech_MedianFiltering = 0x00000004,
        DXVA_DeinterlaceTech_EdgeFiltering = 0x00000010,
        DXVA_DeinterlaceTech_FieldAdaptive = 0x00000020,
        DXVA_DeinterlaceTech_PixelAdaptive = 0x00000040,
        DXVA_DeinterlaceTech_MotionVectorSteered = 0x00000080,
    }
}
