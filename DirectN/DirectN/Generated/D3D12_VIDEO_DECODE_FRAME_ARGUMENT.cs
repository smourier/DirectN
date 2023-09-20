// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_FRAME_ARGUMENT
    {
        public D3D12_VIDEO_DECODE_ARGUMENT_TYPE Type;
        public uint Size;
        public IntPtr pData;
    }
}
