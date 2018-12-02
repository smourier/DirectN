// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2161,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_FLIP = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_FLIPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpSurfCurr;
        public IntPtr lpSurfTarg;
        public uint dwFlags;
        public HRESULT ddRVal;
        public IntPtr Flip;
        public IntPtr lpSurfCurrLeft;
        public IntPtr lpSurfTargLeft;
    }
}
