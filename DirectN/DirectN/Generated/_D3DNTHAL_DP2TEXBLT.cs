// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dnthal.h(845,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2TEXBLT
    {
        public uint dwDDDestSurface;
        public uint dwDDSrcSurface;
        public tagPOINT pDest;
        public _RECTL rSrc;
        public uint dwFlags;
    }
}
