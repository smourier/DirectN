// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4486,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_9
    {
        public IntPtr hDevice;
        public IntPtr hAllocation;
        public uint SegmentId;
        public IntPtr OffsetInPages;
        public IntPtr NumberOfPages;
        public _DXGK_ADL Adl;
        public _DXGK_MAPAPERTUREFLAGS Flags;
        public uint AdlOffset;
        public IntPtr CpuVisibleAddress;
    }
}
