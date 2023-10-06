// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_ALLOCATECONTIGUOUSMEMORY
    {
        public IntPtr NumberOfBytes;
        public long LowestAcceptableAddress;
        public long HighestAcceptableAddress;
        public long BoundaryAddressMultiple;
        public _DXGK_MEMORY_CACHING_TYPE CacheType;
        public IntPtr hMemoryHandle;
        public IntPtr pMemory;
    }
}
