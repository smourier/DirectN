// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(339,9)
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
