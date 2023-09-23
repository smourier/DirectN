// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BARRIER_SUBRESOURCE_RANGE
    {
        public uint IndexOrFirstMipLevel;
        public uint NumMipLevels;
        public uint FirstArraySlice;
        public uint NumArraySlices;
        public uint FirstPlane;
        public uint NumPlanes;
    }
}
