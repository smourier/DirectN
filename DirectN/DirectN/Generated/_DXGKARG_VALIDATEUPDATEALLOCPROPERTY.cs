// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(6023,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_VALIDATEUPDATEALLOCPROPERTY
    {
        public IntPtr hAllocation;
        public uint SupportedSegmentSet;
        public _D3DDDI_SEGMENTPREFERENCE PreferredSegment;
        public D3DDDI_UPDATEALLOCPROPERTY_FLAGS Flags;
        public _DXGKARG_VALIDATEUPDATEALLOCPROPERTY__union_0 __union_4;
    }
}
