// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(5657,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GETMULTIPLANEOVERLAYCAPS
    {
        public uint VidPnSourceId;
        public uint MaxPlanes;
        public uint MaxRGBPlanes;
        public uint MaxYUVPlanes;
        public _DXGK_MULTIPLANEOVERLAYCAPS OverlayCaps;
        public float MaxStretchFactor;
        public float MaxShrinkFactor;
    }
}
