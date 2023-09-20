// generated from <Windows SDK Path>\um\d3dumddi.h
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
