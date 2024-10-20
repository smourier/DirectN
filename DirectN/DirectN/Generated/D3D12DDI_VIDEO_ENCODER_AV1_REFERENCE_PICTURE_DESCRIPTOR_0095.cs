// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR_0095
    {
        public uint ReconstructedPictureResourceIndex;
        public uint TemporalLayerIndexPlus1;
        public uint SpatialLayerIndexPlus1;
        public D3D12DDI_VIDEO_ENCODER_AV1_FRAME_TYPE_0095 FrameType;
        public D3D12DDI_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_WARPED_MOTION_INFO_0095 WarpedMotionInfo;
        public uint OrderHint;
        public uint PictureIndex;
    }
}
