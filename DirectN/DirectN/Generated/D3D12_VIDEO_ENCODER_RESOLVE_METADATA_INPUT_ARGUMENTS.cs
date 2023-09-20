// generated from <Windows SDK Path>\um\d3d12video.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS
    {
        public D3D12_VIDEO_ENCODER_CODEC EncoderCodec;
        public D3D12_VIDEO_ENCODER_PROFILE_DESC EncoderProfile;
        public DXGI_FORMAT EncoderInputFormat;
        public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncodedPictureEffectiveResolution;
        public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER HWLayoutMetadata;
    }
}
