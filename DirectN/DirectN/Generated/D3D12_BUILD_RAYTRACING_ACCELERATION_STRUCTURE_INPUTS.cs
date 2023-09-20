// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS
    {
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
        public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;
        public uint NumDescs;
        public D3D12_ELEMENTS_LAYOUT DescsLayout;
        public D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS__union_0 __union_4;
    }
}
