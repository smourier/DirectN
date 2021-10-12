// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(3829,9)
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
