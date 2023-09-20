// generated from <Windows SDK Path>\um\d3d12video.h
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
