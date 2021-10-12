// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12685,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_QVBR_0080_2
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
