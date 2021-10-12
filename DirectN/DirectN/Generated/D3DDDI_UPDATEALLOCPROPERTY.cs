// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(1575,9)
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
