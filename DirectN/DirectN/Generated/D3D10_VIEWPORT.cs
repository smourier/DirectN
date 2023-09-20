// generated from <Windows SDK Path>\um\d3d10.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_VIEWPORT
    {
        public int TopLeftX;
        public int TopLeftY;
        public uint Width;
        public uint Height;
        public float MinDepth;
        public float MaxDepth;
    }
}
