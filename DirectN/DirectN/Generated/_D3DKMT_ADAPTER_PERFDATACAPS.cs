// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(2170,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADAPTER_PERFDATACAPS
    {
        public uint PhysicalAdapterIndex;
        public ulong MaxMemoryBandwidth;
        public ulong MaxPCIEBandwidth;
        public uint MaxFanRPM;
        public uint TemperatureMax;
        public uint TemperatureWarning;
    }
}
