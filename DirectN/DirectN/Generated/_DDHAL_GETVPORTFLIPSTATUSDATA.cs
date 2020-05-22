// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2545,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_GETFLIPSTATUS = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETVPORTFLIPSTATUSDATA
    {
        public IntPtr lpDD;
        public ulong fpSurface;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortFlipStatus;
    }
}
