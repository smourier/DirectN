// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_MAKERESIDENT
    {
        public uint hPagingQueue;
        public uint NumAllocations;
        public IntPtr AllocationList;
        public IntPtr PriorityList;
        public D3DDDI_MAKERESIDENT_FLAGS Flags;
        public ulong PagingFenceValue;
        public ulong NumBytesToTrim;
    }
}
