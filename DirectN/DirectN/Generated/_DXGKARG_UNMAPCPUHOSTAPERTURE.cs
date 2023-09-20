// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_UNMAPCPUHOSTAPERTURE
    {
        public ulong NumberOfPages;
        public IntPtr pCpuHostAperturePages;
        public ushort SegmentId;
        public ushort PhysicalAdapterIndex;
    }
}
