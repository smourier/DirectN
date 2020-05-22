// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(2062,9)
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
