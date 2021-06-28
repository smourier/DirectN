// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2970,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_DESTROY = System.IntPtr;
using LPDDRAWI_DDMOTIONCOMP_LCL = DirectN._DDRAWI_DDMOTIONCOMP_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DESTROYMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public HRESULT ddRVal;
        public IntPtr DestroyMoComp;
    }
}
