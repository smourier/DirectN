// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_UPDATEALLOCPROPERTY
    {
        public uint hPagingQueue;
        public uint hAllocation;
        public uint SupportedSegmentSet;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegment;
        public D3DDDI_UPDATEALLOCPROPERTY_FLAGS Flags;
        public ulong PagingFenceValue;
        public D3DDDI_UPDATEALLOCPROPERTY__union_0 __union_6;
    }
}
