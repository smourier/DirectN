// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawi.h(1487,1)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_GBL = DirectN._DDRAWI_DDRAWSURFACE_GBL;
using LPDDRAWI_DDRAWSURFACE_INT = DirectN._DDRAWI_DDRAWSURFACE_INT;
using LPDDRAWI_DDRAWSURFACE_MORE = DirectN._DDRAWI_DDRAWSURFACE_MORE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_LCL
    {
        public IntPtr lpSurfMore;
        public IntPtr lpGbl;
        public IntPtr hDDSurface;
        public IntPtr lpAttachList;
        public IntPtr lpAttachListFrom;
        public uint dwLocalRefCnt;
        public uint dwProcessId;
        public uint dwFlags;
        public _DDSCAPS ddsCaps;
        public _DDRAWI_DDRAWSURFACE_LCL__union_0 __union_9;
        public _DDRAWI_DDRAWSURFACE_LCL__union_1 __union_10;
        public uint dwModeCreatedIn;
        public uint dwBackBufferCount;
        public _DDCOLORKEY ddckCKDestBlt;
        public _DDCOLORKEY ddckCKSrcBlt;
        public IntPtr hDC;
        public IntPtr dwReserved1;
        public _DDCOLORKEY ddckCKSrcOverlay;
        public _DDCOLORKEY ddckCKDestOverlay;
        public IntPtr lpSurfaceOverlaying;
        public _DBLNODE dbnOverlayNode;
        public tagRECT rcOverlaySrc;
        public tagRECT rcOverlayDest;
        public uint dwClrXparent;
        public uint dwAlpha;
        public int lOverlayX;
        public int lOverlayY;
    }
}
