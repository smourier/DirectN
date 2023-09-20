// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDICB_EVICT
    {
        public uint NumAllocations;
        public IntPtr AllocationList;
        public D3DDDI_EVICT_FLAGS Flags;
        public ulong NumBytesToTrim;
    }
}
