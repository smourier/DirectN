// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA
    {
        public D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;
        public D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE CompoundPredictionType;
        public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS InterpolationFilter;
        public D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG FrameRestorationConfig;
        public D3D12_VIDEO_ENCODER_AV1_TX_MODE TxMode;
        public uint SuperResDenominator;
        public uint OrderHint;
        public uint PictureIndex;
        public uint TemporalLayerIndexPlus1;
        public uint SpatialLayerIndexPlus1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR[] ReferenceFramesReconPictureDescriptors;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public uint[] ReferenceIndices;
        public uint PrimaryRefFrame;
        public uint RefreshFrameFlags;
        public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG LoopFilter;
        public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG LoopFilterDelta;
        public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG Quantization;
        public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG QuantizationDelta;
        public D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG CDEF;
        public uint QPMapValuesCount;
        public IntPtr pRateControlQPMap;
        public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG CustomSegmentation;
        public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP CustomSegmentsMap;
    }
}
