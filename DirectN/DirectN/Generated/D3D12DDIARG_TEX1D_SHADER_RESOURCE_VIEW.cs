// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_TEX1D_SHADER_RESOURCE_VIEW
    {
        public uint MostDetailedMip;
        public uint FirstArraySlice;
        public uint MipLevels;
        public uint ArraySize;
        public float ResourceMinLODClamp;
    }
}
