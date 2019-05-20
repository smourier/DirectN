// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3114,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONINFO
    {
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint Alignment;
        public IntPtr Size;
        public IntPtr PitchAlignedSize;
        public _DXGK_SEGMENTBANKPREFERENCE HintedBank;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegment;
        public uint SupportedReadSegmentSet;
        public uint SupportedWriteSegmentSet;
        public uint EvictionSegmentSet;
        public _DXGK_ALLOCATIONINFO__union_0 __union_10;
        public IntPtr hAllocation;
        public _DXGK_ALLOCATIONINFO__union_1 __union_12;
        public IntPtr pAllocationUsageHint;
        public uint AllocationPriority;
    }
}
