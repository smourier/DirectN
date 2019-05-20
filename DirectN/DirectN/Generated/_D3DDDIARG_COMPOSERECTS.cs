// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(733,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_COMPOSERECTS
    {
        public IntPtr hSrcResource;
        public uint SrcSubResourceIndex;
        public IntPtr hDstResource;
        public uint DstSubResourceIndex;
        public IntPtr hSrcRectDescsVB;
        public uint NumRects;
        public IntPtr hDstRectDescsVB;
        public _D3DDDI_COMPOSERECTSOP Operation;
        public int XOffset;
        public int YOffset;
    }
}
