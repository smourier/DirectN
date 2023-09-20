// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_MULTIPLANE_OVERLAY_GROUP_CAPS
    {
        public uint NumPlanes;
        public float MaxStretchFactor;
        public float MaxShrinkFactor;
        public uint OverlayCaps;
        public uint StereoCaps;
    }
}
