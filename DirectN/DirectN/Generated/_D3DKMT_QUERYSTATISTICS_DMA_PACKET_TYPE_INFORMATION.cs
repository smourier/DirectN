// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_DMA_PACKET_TYPE_INFORMATION
    {
        public uint PacketSubmited;
        public uint PacketCompleted;
        public uint PacketPreempted;
        public uint PacketFaulted;
    }
}
