// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PRESENTALLOCATIONINFO
    {
        public IntPtr hDeviceSpecificAllocation;
        public ulong AllocationVirtualAddress;
        public long PhysicalAddress;
        public ushort SegmentId;
        public ushort PhysicalAdapterIndex;
    }
}
