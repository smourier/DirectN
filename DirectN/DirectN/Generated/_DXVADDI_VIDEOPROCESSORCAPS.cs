// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(2389,13)
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
