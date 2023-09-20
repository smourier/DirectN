// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_OUTPUT_METADATA_0080
    {
        public D3D12DDI_VIDEO_ENCODER_ENCODE_ERROR_FLAGS_0080 EncodeErrorFlags;
        public ulong ReferencePicturesMotionResultsBitMask;
        public ulong EncodedBitstreamWrittenBytesCount;
        public ulong ReconstructedPictureWrittenBytesCount;
        public uint WrittenSubregionsCount;
        public IntPtr pFrameSubregionMetadata;
    }
}
