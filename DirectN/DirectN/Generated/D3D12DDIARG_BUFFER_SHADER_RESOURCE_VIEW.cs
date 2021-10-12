// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(846,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_BUFFER_SHADER_RESOURCE_VIEW
    {
        public ulong FirstElement;
        public uint NumElements;
        public uint StructureByteStride;
        public D3D12DDI_BUFFER_SRV_FLAGS Flags;
    }
}
