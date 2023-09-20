// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
