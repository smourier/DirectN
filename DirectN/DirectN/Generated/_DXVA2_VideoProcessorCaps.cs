// generated from <Windows SDK Path>\um\dxva2api.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVA2_VideoProcessorCaps
    {
        public uint DeviceCaps;
        public int InputPool;
        public uint NumForwardRefSamples;
        public uint NumBackwardRefSamples;
        public uint Reserved;
        public uint DeinterlaceTechnology;
        public uint ProcAmpControlCaps;
        public uint VideoProcessorOperations;
        public uint NoiseFilterTechnology;
        public uint DetailFilterTechnology;
    }
}
