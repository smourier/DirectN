// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2955,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_QUERYSTATUS = System.IntPtr;
using LPDDRAWI_DDMOTIONCOMP_LCL = DirectN._DDRAWI_DDMOTIONCOMP_LCL;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_QUERYMOCOMPSTATUSDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpSurface;
        public uint dwFlags;
        public HRESULT ddRVal;
        public IntPtr QueryMoCompStatus;
    }
}
