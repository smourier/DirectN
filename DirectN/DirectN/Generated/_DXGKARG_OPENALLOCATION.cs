// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_OPENALLOCATION
    {
        public uint NumAllocations;
        public IntPtr pOpenAllocation;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverSize;
        public _DXGK_OPENALLOCATIONFLAGS Flags;
        public uint SubresourceIndex;
        public IntPtr SubresourceOffset;
        public uint Pitch;
    }
}
