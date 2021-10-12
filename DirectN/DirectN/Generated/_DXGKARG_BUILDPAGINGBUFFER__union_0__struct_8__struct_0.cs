// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4449,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_8__struct_0
    {
        public uint SegmentId;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_8__struct_0__union_0 __union_1;
        public IntPtr VirtualAddress;
        public ulong GpuVirtualAddress;
    }
}
