// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(908,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_QUERY_DATA_VIDEO_DECODE_STATISTICS
    {
        public ulong Status;
        public ulong NumMacroblocksAffected;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
    }
}
