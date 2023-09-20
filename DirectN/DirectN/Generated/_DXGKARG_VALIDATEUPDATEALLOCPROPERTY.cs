// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
