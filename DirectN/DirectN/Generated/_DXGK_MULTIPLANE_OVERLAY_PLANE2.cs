// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5868,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_PLANE2
    {
        public uint LayerIndex;
        public bool Enabled;
        public uint AllocationSegment;
        public PHYSICAL_ADDRESS AllocationAddress;
        public IntPtr hAllocation;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES2 PlaneAttributes;
    }
}
