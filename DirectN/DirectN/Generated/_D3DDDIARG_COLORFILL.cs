// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_COLORFILL
    {
        public IntPtr hResource;
        public uint SubResourceIndex;
        public tagRECT DstRect;
        public uint Color;
        public _D3DDDI_COLORFILLFLAGS Flags;
    }
}
