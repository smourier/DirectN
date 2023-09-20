// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_CONFIGURATION
    {
        public Guid DecodeProfile;
        public D3D12_BITSTREAM_ENCRYPTION_TYPE BitstreamEncryption;
        public D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE InterlaceType;
    }
}
