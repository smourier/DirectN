// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_QUERY_DATA_VIDEO_DECODE_STATISTICS_0022
    {
        public ulong Status;
        public ulong NumMacroblocksAffected;
        public DXGI_RATIONAL FrameRate;
        public uint BitRate;
    }
}
