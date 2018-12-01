// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\codecapi.h(750,1)
using System;

namespace DirectN
{
    [Flags]
    public enum eAVEncVideoChromaSubsampling
    {
        eAVEncVideoChromaSubsamplingFormat_SameAsSource = 0x00000000,
        eAVEncVideoChromaSubsamplingFormat_ProgressiveChroma = 0x00000008,
        eAVEncVideoChromaSubsamplingFormat_Horizontally_Cosited = 0x00000004,
        eAVEncVideoChromaSubsamplingFormat_Vertically_Cosited = 0x00000002,
        eAVEncVideoChromaSubsamplingFormat_Vertically_AlignedChromaPlanes = 0x00000001,
    }
}
