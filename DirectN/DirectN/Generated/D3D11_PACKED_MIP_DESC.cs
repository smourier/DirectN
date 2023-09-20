// generated from <Windows SDK Path>\um\d3d11_2.h
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
