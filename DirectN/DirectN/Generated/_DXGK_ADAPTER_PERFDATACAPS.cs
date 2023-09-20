// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
