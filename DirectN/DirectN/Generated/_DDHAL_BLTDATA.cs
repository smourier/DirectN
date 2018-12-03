// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2067,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_BLT = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPRECT = DirectN.tagRECT;
using RECTL = DirectN._RECTL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_BLTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDDestSurface;
        public RECTL rDest;
        public IntPtr lpDDSrcSurface;
        public RECTL rSrc;
        public uint dwFlags;
        public uint dwROPFlags;
        public _DDBLTFX bltFX;
        public HRESULT ddRVal;
        public IntPtr Blt;
        public bool IsClipped;
        public RECTL rOrigDest;
        public RECTL rOrigSrc;
        public uint dwRectCnt;
        public IntPtr prDestRects;
    }
}
