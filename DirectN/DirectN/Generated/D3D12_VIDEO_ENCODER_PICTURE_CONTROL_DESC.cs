// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC
    {
        public uint IntraRefreshFrameIndex;
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA PictureControlCodecData;
        public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames;
    }
}
