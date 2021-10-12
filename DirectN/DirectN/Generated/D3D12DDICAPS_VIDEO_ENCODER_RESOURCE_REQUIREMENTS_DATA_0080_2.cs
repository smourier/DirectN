// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12975,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICAPS_VIDEO_ENCODER_RESOURCE_REQUIREMENTS_DATA_0080_2
    {
        public uint NodeIndex;
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 Codec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 Profile;
        public DXGI_FORMAT InputFormat;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC_0080 PictureTargetResolution;
        public bool IsSupported;
        public uint CompressedBitstreamBufferAccessAlignment;
        public uint EncoderMetadataBufferAccessAlignment;
        public uint MaxEncoderOutputMetadataBufferSize;
    }
}
