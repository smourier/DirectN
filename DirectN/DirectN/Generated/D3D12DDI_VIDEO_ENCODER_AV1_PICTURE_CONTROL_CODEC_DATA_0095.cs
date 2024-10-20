// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA_0095
    {
        public D3D12DDI_VIDEO_ENCODER_AV1_PICTURE_CONTROL_0095_FLAGS Flags;
        public D3D12DDI_VIDEO_ENCODER_AV1_FRAME_TYPE_0095 FrameType;
        public D3D12DDI_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_0095 CompoundPredictionType;
        public D3D12DDI_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_0095 InterpolationFilter;
        public D3D12DDI_VIDEO_ENCODER_AV1_RESTORATION_CONFIG_0095 FrameRestorationConfig;
        public D3D12DDI_VIDEO_ENCODER_AV1_TX_MODE_0095 TxMode;
        public uint SuperResDenominator;
        public uint OrderHint;
        public uint PictureIndex;
        public uint TemporalLayerIndexPlus1;
        public uint SpatialLayerIndexPlus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D12DDI_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR_0095[] ReferenceFramesReconPictureDescriptors;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public uint[] ReferenceIndices;
        public uint PrimaryRefFrame;
        public uint RefreshFrameFlags;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG_0095 LoopFilter;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG_0095 LoopFilterDelta;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG_0095 Quantization;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG_0095 QuantizationDelta;
        public D3D12DDI_VIDEO_ENCODER_AV1_CDEF_CONFIG_0095 CDEF;
        public uint QPMapValuesCount;
        public IntPtr pRateControlQPMap;
        public D3D12DDI_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG_0095 CustomSegmentation;
        public D3D12DDI_VIDEO_ENCODER_AV1_SEGMENTATION_MAP_0095 CustomSegmentsMap;
    }
}
