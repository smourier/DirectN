// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BARRIER_GROUP
    {
        public D3D12_BARRIER_TYPE Type;
        public uint NumBarriers;
        public D3D12_BARRIER_GROUP__union_0 __union_2;
    }
}
