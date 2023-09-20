// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_CAPTURETOSYSMEM
    {
        public IntPtr hSrcResource;
        public tagRECT SrcRect;
        public IntPtr hDstResource;
        public uint DstSubResourceIndex;
        public tagRECT DstRect;
    }
}
