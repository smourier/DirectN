// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_TILE_REGION_SIZE
    {
        public uint NumTiles;
        public bool UseBox;
        public uint Width;
        public ushort Height;
        public ushort Depth;
    }
}
