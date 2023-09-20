// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
