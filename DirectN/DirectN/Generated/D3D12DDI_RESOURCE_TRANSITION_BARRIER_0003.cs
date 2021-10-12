// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1456,9)
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
