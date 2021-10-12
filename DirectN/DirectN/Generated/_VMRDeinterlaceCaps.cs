// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(20931,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMRDeinterlaceCaps
    {
        public uint dwSize;
        public uint dwNumPreviousOutputFrames;
        public uint dwNumForwardRefSamples;
        public uint dwNumBackwardRefSamples;
        public VMRDeinterlaceTech DeinterlaceTechnology;
    }
}
