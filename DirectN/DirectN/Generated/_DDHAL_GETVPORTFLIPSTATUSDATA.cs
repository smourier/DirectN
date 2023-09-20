// generated from <Windows SDK Path>\um\ddrawi.h
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
