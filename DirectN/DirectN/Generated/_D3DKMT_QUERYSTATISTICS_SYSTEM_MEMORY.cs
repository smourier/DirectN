// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_SYSTEM_MEMORY
    {
        public ulong BytesAllocated;
        public ulong BytesReserved;
        public uint SmallAllocationBlocks;
        public uint LargeAllocationBlocks;
        public ulong WriteCombinedBytesAllocated;
        public ulong WriteCombinedBytesReserved;
        public ulong CachedBytesAllocated;
        public ulong CachedBytesReserved;
        public ulong SectionBytesAllocated;
        public ulong SectionBytesReserved;
        public ulong BytesZeroed;
    }
}
