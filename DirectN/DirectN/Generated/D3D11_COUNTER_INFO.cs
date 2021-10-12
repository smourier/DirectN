// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(6846,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_COUNTER_INFO
    {
        public D3D11_COUNTER LastDeviceDependentCounter;
        public uint NumSimultaneousCounters;
        public byte NumDetectableParallelUnits;
    }
}
