// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawi.h(2093,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_LOCK = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_LOCKDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public uint bHasRect;
        public _RECTL rArea;
        public IntPtr lpSurfData;
        public HRESULT ddRVal;
        public IntPtr Lock;
        public uint dwFlags;
    }
}
