// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS
    {
        public uint NodeIndex;
        public D3D12_VIDEO_ENCODER_CODEC Codec;
        public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
        public DXGI_FORMAT InputFormat;
        public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;
        public bool IsSupported;
        public uint CompressedBitstreamBufferAccessAlignment;
        public uint EncoderMetadataBufferAccessAlignment;
        public uint MaxEncoderOutputMetadataBufferSize;
    }
}
