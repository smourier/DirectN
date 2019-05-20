// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(798,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_FORMAT_COUNT
    {
        public uint NodeIndex;
        public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
        public uint FormatCount;
    }
}
