// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1091,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GET_MULTIPLANE_OVERLAY_CAPS
    {
        public uint hAdapter;
        public uint VidPnSourceId;
        public uint MaxPlanes;
        public uint MaxRGBPlanes;
        public uint MaxYUVPlanes;
        public _D3DKMT_MULTIPLANE_OVERLAY_CAPS OverlayCaps;
        public float MaxStretchFactor;
        public float MaxShrinkFactor;
    }
}
