// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(13795,9)
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
