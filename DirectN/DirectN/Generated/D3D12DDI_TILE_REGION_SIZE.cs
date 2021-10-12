// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(608,9)
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
