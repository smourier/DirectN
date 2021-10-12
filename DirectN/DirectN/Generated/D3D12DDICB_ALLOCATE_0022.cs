// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(4770,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDICB_ALLOCATE_0022
    {
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hResource;
        public uint hKMResource;
        public uint NumAllocations;
        public IntPtr pAllocationInfo;
    }
}
