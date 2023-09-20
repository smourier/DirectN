// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_CODEC_0080 EncoderCodec;
        public D3D12DDI_VIDEO_ENCODER_PROFILE_DESC_0080_2 EncoderProfile;
        public DXGI_FORMAT EncoderInputFormat;
        public D3D12DDI_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC_0080 EncodedPictureEffectiveResolution;
        public D3D12DDI_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER_0080_2 HWLayoutEncoderMetadataDrvBuffer;
    }
}
