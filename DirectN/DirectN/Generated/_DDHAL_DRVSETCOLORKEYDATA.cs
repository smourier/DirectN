// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2363,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_SETCOLORKEY = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DRVSETCOLORKEYDATA
    {
        public IntPtr lpDDSurface;
        public uint dwFlags;
        public _DDCOLORKEY ckNew;
        public HRESULT ddRVal;
        public IntPtr SetColorKey;
    }
}
