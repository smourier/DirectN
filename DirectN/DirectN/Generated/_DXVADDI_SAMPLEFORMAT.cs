// generated from <Windows SDK Path>\um\d3dumddi.h
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
