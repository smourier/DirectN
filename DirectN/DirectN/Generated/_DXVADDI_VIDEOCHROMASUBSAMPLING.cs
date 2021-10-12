// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(982,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVADDI_VIDEOCHROMASUBSAMPLING
    {
        DXVADDI_VideoChromaSubsamplingMask = 0x0000000F,
        DXVADDI_VideoChromaSubsampling_Unknown = 0x00000000,
        DXVADDI_VideoChromaSubsampling_ProgressiveChroma = 0x00000008,
        DXVADDI_VideoChromaSubsampling_Horizontally_Cosited = 0x00000004,
        DXVADDI_VideoChromaSubsampling_Vertically_Cosited = 0x00000002,
        DXVADDI_VideoChromaSubsampling_Vertically_AlignedChromaPlanes = 0x00000001,
        DXVADDI_VideoChromaSubsampling_MPEG2 = 0x00000005,
        DXVADDI_VideoChromaSubsampling_MPEG1 = 0x00000001,
        DXVADDI_VideoChromaSubsampling_DV_PAL = 0x00000006,
        DXVADDI_VideoChromaSubsampling_Cosited = 0x00000007,
    }
}
