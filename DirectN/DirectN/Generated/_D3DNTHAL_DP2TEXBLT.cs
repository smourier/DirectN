// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(845,9)
using System;
using System.Runtime.InteropServices;
using POINT = DirectN.tagPOINT;
using RECTL = DirectN._RECTL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2TEXBLT
    {
        public uint dwDDDestSurface;
        public uint dwDDSrcSurface;
        public POINT pDest;
        public RECTL rSrc;
        public uint dwFlags;
    }
}
