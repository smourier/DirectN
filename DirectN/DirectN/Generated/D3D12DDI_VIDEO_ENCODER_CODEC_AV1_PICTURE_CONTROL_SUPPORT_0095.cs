// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_CODEC_AV1_PICTURE_CONTROL_SUPPORT_0095
    {
        public D3D12DDI_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_0095 PredictionMode;
        public uint MaxUniqueReferencesPerFrame;
        public D3D12DDI_VIDEO_ENCODER_AV1_FRAME_TYPE_0095_FLAGS SupportedFrameTypes;
        public D3D12DDI_VIDEO_ENCODER_AV1_REFERENCE_WARPED_MOTION_TRANSFORMATION_0095_FLAGS SupportedReferenceWarpedMotionFlags;
    }
}
