// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_DESC_0080_2
    {
        public uint IntraRefreshFrameIndex;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA_0080_2 PictureControlCodecData;
        public D3D12DDI_VIDEO_ENCODE_REFERENCE_FRAMES_0080 ReferenceFrames;
    }
}
