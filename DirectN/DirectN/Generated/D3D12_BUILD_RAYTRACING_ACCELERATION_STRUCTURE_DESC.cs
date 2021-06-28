// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(12505,9)
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
