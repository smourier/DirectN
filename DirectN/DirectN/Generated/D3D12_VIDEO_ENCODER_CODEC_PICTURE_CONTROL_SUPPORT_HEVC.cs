// generated from <Windows SDK Path>\um\d3d12video.h
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
