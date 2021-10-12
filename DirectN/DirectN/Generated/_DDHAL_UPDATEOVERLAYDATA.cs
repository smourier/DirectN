// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(2119,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_UPDATEOVERLAY = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_UPDATEOVERLAYDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDDestSurface;
        public _RECTL rDest;
        public IntPtr lpDDSrcSurface;
        public _RECTL rSrc;
        public uint dwFlags;
        public _DDOVERLAYFX overlayFX;
        public HRESULT ddRVal;
        public IntPtr UpdateOverlay;
    }
}
