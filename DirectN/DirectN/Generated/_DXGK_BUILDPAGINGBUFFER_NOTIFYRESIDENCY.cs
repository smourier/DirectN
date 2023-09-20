// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY
    {
        public IntPtr hAllocation;
        public _D3DGPU_PHYSICAL_ADDRESS PhysicalAddress;
        public _DXGK_BUILDPAGINGBUFFER_NOTIFYRESIDENCY__union_0 __union_2;
    }
}
