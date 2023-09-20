// generated from <Windows SDK Path>\um\d3dhal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2TEXBLT
    {
        public uint dwDDDestSurface;
        public uint dwDDSrcSurface;
        public tagPOINT pDest;
        public _RECTL rSrc;
        public uint dwFlags;
    }
}
