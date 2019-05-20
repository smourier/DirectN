// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(724,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_VSYNC_INFO
    {
        public uint LayerIndex;
        public bool Enabled;
        public PHYSICAL_ADDRESS PhysicalAddress;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES PlaneAttributes;
    }
}
