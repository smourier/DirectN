// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(8039,9)
using System;
using System.Runtime.InteropServices;
using D3D12DDI_GPU_VIRTUAL_ADDRESS = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_0054
    {
        public D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC_0054 Desc;
        public uint NumSourceAccelerationStructures;
        public IntPtr pSourceAccelerationStructureData;
    }
}
