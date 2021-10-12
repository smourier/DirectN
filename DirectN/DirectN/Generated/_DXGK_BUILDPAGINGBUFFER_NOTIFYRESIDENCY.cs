// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(4288,9)
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
