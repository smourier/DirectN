// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDIARG_PRESENTMULTIPLANEOVERLAY
    {
        public uint VidPnSourceId;
        public _D3DDDI_PRESENTFLAGS Flags;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public uint PresentPlaneCount;
        public IntPtr pPresentPlanes;
        public uint Reserved;
    }
}
