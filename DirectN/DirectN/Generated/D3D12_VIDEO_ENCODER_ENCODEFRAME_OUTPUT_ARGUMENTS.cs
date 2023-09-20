// generated from <Windows SDK Path>\um\d3d12video.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_OUTPUT_ARGUMENTS
    {
        public D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM Bitstream;
        public D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE ReconstructedPicture;
        public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER EncoderOutputMetadata;
    }
}
