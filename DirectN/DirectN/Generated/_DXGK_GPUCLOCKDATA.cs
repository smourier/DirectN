// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_GPUCLOCKDATA
    {
        public ulong GpuFrequency;
        public ulong GpuClockCounter;
        public ulong CpuClockCounter;
        public _DXGK_GPUCLOCKDATA_FLAGS Flags;
    }
}
