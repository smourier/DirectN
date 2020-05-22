// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2886,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEX2D_SRV
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint PlaneSlice;
        public float ResourceMinLODClamp;
    }
}
