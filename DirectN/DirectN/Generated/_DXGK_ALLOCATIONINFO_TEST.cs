// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONINFO_TEST
    {
        public uint Alignment;
        public IntPtr Size;
        public IntPtr PitchAlignedSize;
        public _DXGK_SEGMENTBANKPREFERENCE HintedBank;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegment;
        public uint SupportedReadSegmentSet;
        public uint SupportedWriteSegmentSet;
        public uint EvictionSegmentSet;
        public uint PhysicalAdapterIndex;
        public _DXGK_ALLOCATIONINFOFLAGS_WDDM2_0 FlagsWddm2;
        public uint AllocationPriority;
        public _DXGK_ALLOCATIONINFOFLAGS2 Flags2;
    }
}
