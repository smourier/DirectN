// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(8074,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_COPY_RAYTRACING_ACCELERATION_STRUCTURE_0054
    {
        public ulong DestAccelerationStructureData;
        public ulong SourceAccelerationStructureData;
        public D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE Mode;
    }
}
