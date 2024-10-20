// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONINFO
    {
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public _DXGK_ALLOCATIONINFO__union_0 __union_2;
        public IntPtr Size;
        public IntPtr PitchAlignedSize;
        public _DXGK_SEGMENTBANKPREFERENCE HintedBank;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegment;
        public _DXGK_ALLOCATIONINFO__union_1 __union_7;
        public uint SupportedWriteSegmentSet;
        public uint EvictionSegmentSet;
        public _DXGK_ALLOCATIONINFO__union_2 __union_10;
        public IntPtr hAllocation;
        public _DXGK_ALLOCATIONINFO__union_3 __union_12;
        public IntPtr pAllocationUsageHint;
        public uint AllocationPriority;
        public _DXGK_ALLOCATIONINFOFLAGS2 Flags2;
    }
}
