// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT
    {
        public D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE PredictionMode;
        public uint MaxUniqueReferencesPerFrame;
        public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS SupportedFrameTypes;
        public D3D12_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_FLAGS SupportedReferenceWarpedMotionFlags;
    }
}
