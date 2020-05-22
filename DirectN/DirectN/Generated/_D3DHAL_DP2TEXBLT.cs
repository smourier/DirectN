// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dhal.h(1217,9)
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
