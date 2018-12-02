// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1936,9)
using System;
using System.Runtime.InteropServices;
using DDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;
using DDVIDEOPORTINFO = DirectN._DDVIDEOPORTINFO;
using LPDDRAWI_DDRAWSURFACE_INT = DirectN._DDRAWI_DDRAWSURFACE_INT;
using LPDDRAWI_DDVIDEOPORT_INT = DirectN._DDRAWI_DDVIDEOPORT_INT;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;
using LPDDVIDEOPORTINFO = DirectN._DDVIDEOPORTINFO;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDVIDEOPORT_LCL
    {
        public IntPtr lpDD;
        public DDVIDEOPORTDESC ddvpDesc;
        public DDVIDEOPORTINFO ddvpInfo;
        public IntPtr lpSurface;
        public IntPtr lpVBISurface;
        public IntPtr lpFlipInts;
        public uint dwNumAutoflip;
        public uint dwProcessID;
        public uint dwStateFlags;
        public uint dwFlags;
        public uint dwRefCnt;
        public ulong fpLastFlip;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
        public IntPtr hDDVideoPort;
        public uint dwNumVBIAutoflip;
        public IntPtr lpVBIDesc;
        public IntPtr lpVideoDesc;
        public IntPtr lpVBIInfo;
        public IntPtr lpVideoInfo;
        public uint dwVBIProcessID;
        public IntPtr lpVPNotify;
    }
}
