// generated from <Windows SDK Path>\um\d3d12umddi.h
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
