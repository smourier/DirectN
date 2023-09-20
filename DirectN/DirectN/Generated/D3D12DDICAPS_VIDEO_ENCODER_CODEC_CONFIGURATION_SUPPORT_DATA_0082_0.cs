// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_DATA_0082_0
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 Codec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 Profile;
        public bool IsSupported;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT_0082_0 CodecSupportLimits;
    }
}
