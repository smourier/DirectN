// generated from <Windows SDK Path>\um\d3d12.h
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
