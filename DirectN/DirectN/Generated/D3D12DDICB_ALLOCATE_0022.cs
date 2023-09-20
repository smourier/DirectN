// generated from <Windows SDK Path>\um\d3d12umddi.h
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
