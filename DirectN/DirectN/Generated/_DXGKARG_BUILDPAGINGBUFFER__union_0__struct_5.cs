// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3962,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_5
    {
        public IntPtr hDevice;
        public IntPtr hAllocation;
        public uint SegmentId;
        public IntPtr OffsetInPages;
        public IntPtr NumberOfPages;
        public int pMdl;
        public _DXGK_MAPAPERTUREFLAGS Flags;
        public uint MdlOffset;
    }
}
