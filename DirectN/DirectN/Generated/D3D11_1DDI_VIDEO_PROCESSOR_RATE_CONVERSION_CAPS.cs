// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDI_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS
    {
        public uint PastFrames;
        public uint FutureFrames;
        public uint ConversionCaps;
        public uint ITelecineCaps;
        public uint CustomRateCount;
    }
}
