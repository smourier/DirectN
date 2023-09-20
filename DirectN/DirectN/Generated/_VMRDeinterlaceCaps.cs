// generated from <Windows SDK Path>\um\strmif.h
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
