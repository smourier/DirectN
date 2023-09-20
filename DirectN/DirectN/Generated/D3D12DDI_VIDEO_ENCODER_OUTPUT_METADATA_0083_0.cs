// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_OUTPUT_METADATA_0083_0
    {
        public ulong EncodeErrorFlags;
        public D3D12DDI_VIDEO_ENCODER_METADATA_STATISTICS_0083_0 EncodeStats;
        public ulong EncodedBitstreamWrittenBytesCount;
        public ulong WrittenSubregionsCount;
    }
}
