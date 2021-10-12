// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4374,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_2
    {
        public IntPtr hAllocation;
        public _DXGK_DISCARDCONTENTFLAGS Flags;
        public uint SegmentId;
        public PHYSICAL_ADDRESS SegmentAddress;
    }
}
