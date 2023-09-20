// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_0054
    {
        public ulong DestAccelerationStructureData;
        public D3D12DDI_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS_0054 Inputs;
        public ulong SourceAccelerationStructureData;
        public ulong ScratchAccelerationStructureData;
        public uint NumPostbuildInfoDescs;
        public IntPtr pPostbuildInfoDescs;
    }
}
