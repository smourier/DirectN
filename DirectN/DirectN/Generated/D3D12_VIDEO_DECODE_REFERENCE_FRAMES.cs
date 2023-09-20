// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_DECODE_REFERENCE_FRAMES
    {
        public uint NumTexture2Ds;
        public IntPtr ppTexture2Ds;
        public IntPtr pSubresources;
        public IntPtr ppHeaps;
    }
}
