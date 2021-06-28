// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2622,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TILE_REGION_SIZE
    {
        public uint NumTiles;
        public bool UseBox;
        public uint Width;
        public ushort Height;
        public ushort Depth;
    }
}
