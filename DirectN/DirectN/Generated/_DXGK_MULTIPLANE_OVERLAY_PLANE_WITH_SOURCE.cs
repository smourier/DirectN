// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(456,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_PLANE_WITH_SOURCE
    {
        public IntPtr hAllocation;
        public uint VidPnSourceId;
        public uint LayerIndex;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES2 PlaneAttributes;
    }
}
