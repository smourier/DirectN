// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12208,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_CBR_0080
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
