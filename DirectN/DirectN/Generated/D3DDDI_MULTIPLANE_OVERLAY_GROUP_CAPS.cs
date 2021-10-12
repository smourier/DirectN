// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2680,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_MULTIPLANE_OVERLAY_GROUP_CAPS
    {
        public uint NumPlanes;
        public float MaxStretchFactor;
        public float MaxShrinkFactor;
        public uint OverlayCaps;
    }
}
