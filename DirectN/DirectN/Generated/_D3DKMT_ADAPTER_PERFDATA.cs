// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1913,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADAPTER_PERFDATA
    {
        public uint PhysicalAdapterIndex;
        public ulong MemoryFrequency;
        public ulong MaxMemoryFrequency;
        public ulong MaxMemoryFrequencyOC;
        public ulong MemoryBandwidth;
        public ulong PCIEBandwidth;
        public uint FanRPM;
        public uint Power;
        public uint Temperature;
        public byte PowerStateOverride;
    }
}
