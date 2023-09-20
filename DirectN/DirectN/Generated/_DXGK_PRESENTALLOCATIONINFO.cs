// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRESENTALLOCATIONINFO
    {
        public IntPtr hDeviceSpecificAllocation;
        public ulong AllocationVirtualAddress;
        public PHYSICAL_ADDRESS PhysicalAddress;
        public ushort SegmentId;
        public ushort PhysicalAdapterIndex;
    }
}
