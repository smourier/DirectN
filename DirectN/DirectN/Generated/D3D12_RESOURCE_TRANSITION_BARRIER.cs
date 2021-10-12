// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2834,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_TRANSITION_BARRIER
    {
        public IntPtr pResource;
        public uint Subresource;
        public D3D12_RESOURCE_STATES StateBefore;
        public D3D12_RESOURCE_STATES StateAfter;
    }
}
