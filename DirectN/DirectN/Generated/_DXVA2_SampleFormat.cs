// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2api.h(215,1)
using System;

namespace DirectN
{
    [Flags]
    public enum _DXVA2_SampleFormat
    {
        DXVA2_SampleFormatMask = 0x000000FF,
        DXVA2_SampleUnknown = 0x00000000,
        DXVA2_SampleProgressiveFrame = 0x00000002,
        DXVA2_SampleFieldInterleavedEvenFirst = 0x00000003,
        DXVA2_SampleFieldInterleavedOddFirst = 0x00000004,
        DXVA2_SampleFieldSingleEven = 0x00000005,
        DXVA2_SampleFieldSingleOdd = 0x00000006,
        DXVA2_SampleSubStream = 0x00000007,
    }
}
