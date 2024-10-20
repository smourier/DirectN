// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT
    {
        public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS SupportedFeatureFlags;
        public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS RequiredFeatureFlags;
        public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS SupportedInterpolationFilters;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)] 
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS[] SupportedRestorationParams;
        public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS SupportedSegmentationModes;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS[] SupportedTxModes;
        public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE SegmentationBlockSize;
        public D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS PostEncodeValuesFlags;
        public uint MaxTemporalLayers;
        public uint MaxSpatialLayers;
    }
}
