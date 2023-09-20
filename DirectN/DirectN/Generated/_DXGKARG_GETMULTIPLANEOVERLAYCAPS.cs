// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
