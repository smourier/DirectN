// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2api.h(228,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_VideoChromaSubSampling
    {
        DXVA2_VideoChromaSubsamplingMask = 0x0000000F,
        DXVA2_VideoChromaSubsampling_Unknown = 0x00000000,
        DXVA2_VideoChromaSubsampling_ProgressiveChroma = 0x00000008,
        DXVA2_VideoChromaSubsampling_Horizontally_Cosited = 0x00000004,
        DXVA2_VideoChromaSubsampling_Vertically_Cosited = 0x00000002,
        DXVA2_VideoChromaSubsampling_Vertically_AlignedChromaPlanes = 0x00000001,
        DXVA2_VideoChromaSubsampling_MPEG2 = 0x00000005,
        DXVA2_VideoChromaSubsampling_MPEG1 = 0x00000001,
        DXVA2_VideoChromaSubsampling_DV_PAL = 0x00000006,
        DXVA2_VideoChromaSubsampling_Cosited = 0x00000007,
    }
}
