// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_0095
    {
        public ulong CompoundPredictionType;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG_0095 LoopFilter;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG_0095 LoopFilterDelta;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG_0095 Quantization;
        public D3D12DDI_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG_0095 QuantizationDelta;
        public D3D12DDI_VIDEO_ENCODER_AV1_CDEF_CONFIG_0095 CDEF;
        public D3D12DDI_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG_0095 SegmentationConfig;
        public ulong PrimaryRefFrame;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public ulong[] ReferenceIndices;
    }
}
