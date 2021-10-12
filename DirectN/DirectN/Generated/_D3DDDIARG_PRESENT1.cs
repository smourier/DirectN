// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2869,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_PRESENT1
    {
        public IntPtr phSrcResources;
        public uint SrcResources;
        public IntPtr hDstResource;
        public uint DstSubResourceIndex;
        public _D3DDDI_PRESENTFLAGS Flags;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public uint Reserved;
        public IntPtr pDirtyRects;
        public uint DirtyRects;
        public uint BackBufferMultiplicity;
    }
}
