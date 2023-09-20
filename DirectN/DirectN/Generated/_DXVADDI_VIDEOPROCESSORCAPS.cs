// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_VIDEOPROCESSORCAPS
    {
        public _D3DDDI_POOL InputPool;
        public uint NumForwardRefSamples;
        public uint NumBackwardRefSamples;
        public _D3DDDIFORMAT OutputFormat;
        public uint DeinterlaceTechnology;
        public uint ProcAmpControlCaps;
        public uint VideoProcessorOperations;
        public uint NoiseFilterTechnology;
        public uint DetailFilterTechnology;
    }
}
