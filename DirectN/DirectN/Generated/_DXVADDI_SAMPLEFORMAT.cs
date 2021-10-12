// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(970,9)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVADDI_SAMPLEFORMAT
    {
        DXVADDI_SampleFormatMask = 0x000000FF,
        DXVADDI_SampleUnknown = 0x00000000,
        DXVADDI_SampleProgressiveFrame = 0x00000002,
        DXVADDI_SampleFieldInterleavedEvenFirst = 0x00000003,
        DXVADDI_SampleFieldInterleavedOddFirst = 0x00000004,
        DXVADDI_SampleFieldSingleEven = 0x00000005,
        DXVADDI_SampleFieldSingleOdd = 0x00000006,
        DXVADDI_SampleSubStream = 0x00000007,
    }
}
