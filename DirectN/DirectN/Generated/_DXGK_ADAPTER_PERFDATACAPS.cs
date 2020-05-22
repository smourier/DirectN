// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(2044,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGK_ADAPTER_PERFDATACAPS
    {
        public ulong MaxMemoryBandwidth;
        public ulong MaxPCIEBandwidth;
        public uint MaxFanRPM;
        public uint TemperatureMax;
        public uint TemperatureWarning;
    }
}
