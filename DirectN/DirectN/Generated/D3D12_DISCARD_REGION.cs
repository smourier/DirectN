// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DISCARD_REGION
    {
        public uint NumRects;
        public IntPtr pRects;
        public uint FirstSubresource;
        public uint NumSubresources;
    }
}
