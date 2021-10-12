// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3268,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_NODE_INFORMATION
    {
        public long RunningTime;
        public uint ContextSwitch;
        public _D3DKMT_QUERYSTATISTICS_PREEMPTION_INFORMATION PreemptionStatistics;
        public _D3DKMT_QUERYSTATISTICS_PACKET_INFORMATION PacketStatistics;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] Reserved;
    }
}
