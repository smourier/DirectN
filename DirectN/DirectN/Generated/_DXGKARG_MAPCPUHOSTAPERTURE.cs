// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5148,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_MAPCPUHOSTAPERTURE
    {
        public IntPtr hAllocation;
        public ushort SegmentId;
        public ushort PhysicalAdapterIndex;
        public ulong NumberOfPages;
        public IntPtr pCpuHostAperturePages;
        public IntPtr pMemorySegmentPages;
    }
}
