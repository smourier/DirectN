// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_QVBR
    {
        public uint InitialQP;
        public uint MinQP;
        public uint MaxQP;
        public ulong MaxFrameBitSize;
        public ulong TargetAvgBitRate;
        public ulong PeakBitRate;
        public uint ConstantQualityTarget;
    }
}
