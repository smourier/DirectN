// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(468,9)
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
