// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_OPENHEAP_0003
    {
        public uint NumAllocations;
        public IntPtr pOpenAllocationInfo;
        public D3D10DDI_HKMRESOURCE hKMResource;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public D3D12DDI_RESOURCE_STATES InitialResourceState;
    }
}
