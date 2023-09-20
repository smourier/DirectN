// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VIDMM_ESCAPE__union_0__struct_10
    {
        public _D3DKMT_DEFRAG_ESCAPE_OPERATION Operation;
        public uint SegmentId;
        public ulong TotalCommitted;
        public ulong TotalFree;
        public ulong LargestGapBefore;
        public ulong LargestGapAfter;
    }
}
