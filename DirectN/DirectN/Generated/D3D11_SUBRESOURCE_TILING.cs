// generated from <Windows SDK Path>\um\d3d11_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SUBRESOURCE_TILING
    {
        public uint WidthInTiles;
        public ushort HeightInTiles;
        public ushort DepthInTiles;
        public uint StartTileIndexInOverallResource;
    }
}
