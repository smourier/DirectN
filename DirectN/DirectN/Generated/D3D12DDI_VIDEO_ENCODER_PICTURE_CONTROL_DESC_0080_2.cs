// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13059,9)
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
