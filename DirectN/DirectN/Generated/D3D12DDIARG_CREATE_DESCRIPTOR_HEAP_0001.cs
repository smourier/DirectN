// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_DESCRIPTOR_HEAP_0001
    {
        public D3D12DDI_DESCRIPTOR_HEAP_TYPE Type;
        public uint NumDescriptors;
        public D3D12DDI_DESCRIPTOR_HEAP_FLAGS Flags;
        public uint NodeMask;
    }
}
