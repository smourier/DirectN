// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR
    {
        public uint ReconstructedPictureResourceIndex;
        public uint TemporalLayerIndexPlus1;
        public uint SpatialLayerIndexPlus1;
        public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;
        public D3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO WarpedMotionInfo;
        public uint OrderHint;
        public uint PictureIndex;
    }
}
