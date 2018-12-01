// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_2.h(91,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TILE_REGION_SIZE
    {
        public uint NumTiles;
        public bool bUseBox;
        public uint Width;
        public ushort Height;
        public ushort Depth;
    }
}
