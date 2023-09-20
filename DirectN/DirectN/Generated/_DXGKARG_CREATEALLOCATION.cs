// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEALLOCATION
    {
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint NumAllocations;
        public IntPtr pAllocationInfo;
        public IntPtr hResource;
        public _DXGK_CREATEALLOCATIONFLAGS Flags;
    }
}
