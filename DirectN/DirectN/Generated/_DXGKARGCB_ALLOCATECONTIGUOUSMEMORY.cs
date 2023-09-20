// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_ALLOCATECONTIGUOUSMEMORY
    {
        public IntPtr NumberOfBytes;
        public PHYSICAL_ADDRESS LowestAcceptableAddress;
        public PHYSICAL_ADDRESS HighestAcceptableAddress;
        public PHYSICAL_ADDRESS BoundaryAddressMultiple;
        public _DXGK_MEMORY_CACHING_TYPE CacheType;
        public IntPtr hMemoryHandle;
        public IntPtr pMemory;
    }
}
