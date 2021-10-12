// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(5021,9)
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
