// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_CREATECONTEXTALLOCATION
    {
        public _DXGK_CREATECONTEXTALLOCATIONFLAGS ContextAllocationFlags;
        public IntPtr hAdapter;
        public IntPtr hDevice;
        public IntPtr hContext;
        public IntPtr hDriverAllocation;
        public IntPtr Size;
        public uint Alignment;
        public uint SupportedSegmentSet;
        public uint EvictionSegmentSet;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegment;
        public _DXGK_SEGMENTBANKPREFERENCE HintedBank;
        public _DXGK_ALLOCATIONINFOFLAGS Flags;
        public IntPtr hAllocation;
        public uint PhysicalAdapterIndex;
    }
}
