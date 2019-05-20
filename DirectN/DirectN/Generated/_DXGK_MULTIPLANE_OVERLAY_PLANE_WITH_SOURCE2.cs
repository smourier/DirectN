// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5743,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MULTIPLANE_OVERLAY_PLANE_WITH_SOURCE2
    {
        public IntPtr hAllocation;
        public uint VidPnSourceId;
        public uint LayerIndex;
        public _DXGK_MULTIPLANE_OVERLAY_ATTRIBUTES3 PlaneAttributes;
    }
}
