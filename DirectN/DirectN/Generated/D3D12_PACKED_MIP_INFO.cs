// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_PACKED_MIP_INFO
    {
        public byte NumStandardMips;
        public byte NumPackedMips;
        public uint NumTilesForPackedMips;
        public uint StartTileIndexInOverallResource;
    }
}
