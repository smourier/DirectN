// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d10.h(683,9)
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
