// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(1378,9)
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
