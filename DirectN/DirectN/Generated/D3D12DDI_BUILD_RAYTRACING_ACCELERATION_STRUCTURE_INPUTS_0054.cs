// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(7820,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS_0054
    {
        public D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
        public D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;
        public uint NumDescs;
        public D3D12DDI_ELEMENTS_LAYOUT DescsLayout;
        public D3D12DDI_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS_0054__union_0 __union_4;
    }
}
