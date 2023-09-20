// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_1
    {
        public IntPtr hAllocation;
        public IntPtr FillSize;
        public uint FillPattern;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_1__struct_0 Destination;
    }
}
