// generated from <Windows SDK Path>\um\d3d11_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT
    {
        public bool Enable;
        public uint Width;
        public uint Height;
        public DXGI_FORMAT Format;
    }
}
