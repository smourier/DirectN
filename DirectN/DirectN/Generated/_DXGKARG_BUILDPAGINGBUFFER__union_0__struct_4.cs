// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_4
    {
        public uint SegmentId;
        public PHYSICAL_ADDRESS PhysicalAddress;
    }
}
