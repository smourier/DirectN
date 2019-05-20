// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_2.h(131,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_PACKED_MIP_DESC
    {
        public byte NumStandardMips;
        public byte NumPackedMips;
        public uint NumTilesForPackedMips;
        public uint StartTileIndexInOverallResource;
    }
}
