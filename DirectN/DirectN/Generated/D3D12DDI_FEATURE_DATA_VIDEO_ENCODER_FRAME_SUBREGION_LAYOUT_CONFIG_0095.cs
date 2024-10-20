// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_FEATURE_DATA_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG_0095
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 Codec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 Profile;
        public D3D12DDI_VIDEO_ENCODER_LEVEL_SETTING_0080_2 Level;
        public D3D12DDI_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_0080 SubregionMode;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC_0080 FrameResolution;
        public D3D12DDI_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT_0095 CodecSupport;
        public bool IsSupported;
    }
}
