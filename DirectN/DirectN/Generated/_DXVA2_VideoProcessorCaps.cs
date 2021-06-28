// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva2api.h(436,9)
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
