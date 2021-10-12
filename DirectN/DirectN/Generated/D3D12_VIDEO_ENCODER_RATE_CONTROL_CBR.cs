// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(5578,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR
    {
        public uint InitialQP;
        public uint MinQP;
        public uint MaxQP;
        public ulong MaxFrameBitSize;
        public ulong TargetBitRate;
        public ulong VBVCapacity;
        public ulong InitialVBVFullness;
    }
}
