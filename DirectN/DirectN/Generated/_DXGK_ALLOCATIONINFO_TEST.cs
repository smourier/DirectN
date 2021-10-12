// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3524,9)
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
