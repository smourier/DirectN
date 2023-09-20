// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_UPDATEPAGETABLE
    {
        public uint PageTableLevel;
        public IntPtr hAllocation;
        public _DXGK_PAGETABLEUPDATEADDRESS PageTableAddress;
        public IntPtr pPageTableEntries;
        public uint StartIndex;
        public uint NumPageTableEntries;
        public uint Reserved0;
        public _DXGK_UPDATEPAGETABLEFLAGS Flags;
        public ulong DriverProtection;
        public ulong AllocationOffsetInBytes;
        public IntPtr hProcess;
        public _DXGK_PAGETABLEUPDATEMODE UpdateMode;
        public IntPtr pPageTableEntries64KB;
        public ulong FirstPteVirtualAddress;
    }
}
