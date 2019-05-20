// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_2.h(114,9)
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
