// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2794,9)
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
