// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC
    {
        public ulong DestAccelerationStructureData;
        public D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS Inputs;
        public ulong SourceAccelerationStructureData;
        public ulong ScratchAccelerationStructureData;
    }
}
