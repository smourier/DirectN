// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_VIDEO_ENCODER_SUPPORT_DATA_0080_2
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 Codec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 TargetProfile;
        public D3D12DDI_VIDEO_ENCODER_LEVEL_SETTING_0080_2 TargetLevel;
        public DXGI_FORMAT InputFormat;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_0080_2 CodecConfiguration;
        public D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_0080_2 RateControl;
        public D3D12DDI_VIDEO_ENCODER_INTRA_REFRESH_MODE_0080 IntraRefresh;
        public D3D12DDI_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_0080 SubregionFrameEncoding;
        public uint ResolutionsListCount;
        public IntPtr pResolutionList;
        public D3D12DDI_VIDEO_ENCODER_VALIDATION_FLAGS_0080 ValidationFlags;
        public D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAGS_0080 SupportFlags;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 SuggestedProfile;
        public D3D12DDI_VIDEO_ENCODER_LEVEL_SETTING_0080_2 SuggestedLevel;
        public IntPtr pResolutionDependentSupport;
    }
}
