// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6963,9)
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
