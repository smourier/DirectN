// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1126,9)
using System;
using System.Runtime.InteropServices;
using DDARGB = DirectN._DDARGB;
using DDBLTFX = DirectN._DDBLTFX;
using LPRECT = DirectN.tagRECT;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;
using RECTL = DirectN._RECTL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_BLTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDDestSurface;
        public RECTL rDest;
        public IntPtr lpDDSrcSurface;
        public RECTL rSrc;
        public uint dwFlags;
        public uint dwROPFlags;
        public DDBLTFX bltFX;
        public HRESULT ddRVal;
        public IntPtr Blt;
        public bool IsClipped;
        public RECTL rOrigDest;
        public RECTL rOrigSrc;
        public uint dwRectCnt;
        public IntPtr prDestRects;
        public uint dwAFlags;
        public DDARGB ddargbScaleFactors;
    }
}
