// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3903,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0
    {
        public IntPtr hAllocation;
        public uint TransferOffset;
        public IntPtr TransferSize;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0__struct_0 Source;
        public _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_0__struct_1 Destination;
        public _DXGK_TRANSFERFLAGS Flags;
        public uint MdlOffset;
    }
}
