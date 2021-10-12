// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(5978,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC
    {
        public uint MaxL0ReferencesForP;
        public uint MaxL0ReferencesForB;
        public uint MaxL1ReferencesForB;
        public uint MaxLongTermReferences;
        public uint MaxDPBCapacity;
    }
}
