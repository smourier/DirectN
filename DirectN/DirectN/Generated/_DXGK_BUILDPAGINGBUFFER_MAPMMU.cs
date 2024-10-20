// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_MAPMMU
    {
        public IntPtr hAllocation;
        public ulong VirtualAddress;
        public ushort MmuId;
        public ushort SegmentId;
        public uint AllocationOffsetInPages;
        public _DXGK_ADL Adl;
    }
}
