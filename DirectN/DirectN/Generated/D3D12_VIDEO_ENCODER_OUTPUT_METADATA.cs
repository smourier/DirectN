// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_OUTPUT_METADATA
    {
        public ulong EncodeErrorFlags;
        public D3D12_VIDEO_ENCODER_OUTPUT_METADATA_STATISTICS EncodeStats;
        public ulong EncodedBitstreamWrittenBytesCount;
        public ulong WrittenSubregionsCount;
    }
}
