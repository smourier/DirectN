// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_STREAM_ARGUMENTS_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_COMPRESSED_BITSTREAM_0080 CompressedBitstream;
        public D3D12DDI_VIDEO_ENCODE_RECONSTRUCTED_PICTURE_0080 ReconstructedPicture;
        public D3D12DDI_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER_0080_2 HWLayoutEncoderMetadataDrvBuffer;
    }
}
