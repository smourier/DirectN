// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RESOURCE_TRANSITION_BARRIER_0003
    {
        public D3D10DDI_HRESOURCE hResource;
        public uint Subresource;
        public D3D12DDI_RESOURCE_STATES StateBefore;
        public D3D12DDI_RESOURCE_STATES StateAfter;
    }
}
