// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(4897,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM1_3DDI_TILE_REGION_SIZE
    {
        public uint NumTiles;
        public bool bUseBox;
        public uint Width;
        public ushort Height;
        public ushort Depth;
    }
}
