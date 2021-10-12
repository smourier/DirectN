// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(203,9)
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
