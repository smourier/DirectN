// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
