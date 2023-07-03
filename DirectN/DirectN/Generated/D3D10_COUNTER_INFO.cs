// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10.h(4855,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_COUNTER_INFO
    {
        public D3D10_COUNTER LastDeviceDependentCounter;
        public uint NumSimultaneousCounters;
        public byte NumDetectableParallelUnits;
    }
}
