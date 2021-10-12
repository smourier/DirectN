// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13443,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_VIDEO_ENCODER_SUPPORT_DATA_0082_0
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 Codec;
        public DXGI_FORMAT InputFormat;
        public D3D12DDI_VIDEO_ENCODER_CODEC_CONFIGURATION_0082_0 CodecConfiguration;
        public D3D12DDI_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE_0082_0 CodecGopSequence;
        public D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_0080_2 RateControl;
        public D3D12DDI_VIDEO_ENCODER_INTRA_REFRESH_MODE_0080 IntraRefresh;
        public D3D12DDI_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_0080 SubregionFrameEncoding;
        public uint ResolutionsListCount;
        public IntPtr pResolutionList;
        public uint MaxDPBCapacity;
        public D3D12DDI_VIDEO_ENCODER_VALIDATION_FLAGS_0082_0 ValidationFlags;
        public D3D12DDI_VIDEO_ENCODER_SUPPORT_FLAGS_0082_0 SupportFlags;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 SuggestedProfile;
        public D3D12DDI_VIDEO_ENCODER_LEVEL_SETTING_0080_2 SuggestedLevel;
        public IntPtr pResolutionDependentSupport;
    }
}
