// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(337,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA_VideoChromaSubsampling
    {
        DXVA_VideoChromaSubsamplingShift = 0x00000008,
        DXVA_VideoChromaSubsamplingMask = 0x00000F00,
        DXVA_VideoChromaSubsampling_Unknown = 0x00000000,
        DXVA_VideoChromaSubsampling_ProgressiveChroma = 0x00000008,
        DXVA_VideoChromaSubsampling_Horizontally_Cosited = 0x00000004,
        DXVA_VideoChromaSubsampling_Vertically_Cosited = 0x00000002,
        DXVA_VideoChromaSubsampling_Vertically_AlignedChromaPlanes = 0x00000001,
        DXVA_VideoChromaSubsampling_MPEG2 = 0x00000005,
        DXVA_VideoChromaSubsampling_MPEG1 = 0x00000001,
        DXVA_VideoChromaSubsampling_DV_PAL = 0x00000006,
        DXVA_VideoChromaSubsampling_Cosited = 0x00000007,
    }
}
