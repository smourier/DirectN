// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(181,9)
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
