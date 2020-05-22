// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2398,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_FLIPTOGDISURFACE = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_FLIPTOGDISURFACEDATA
    {
        public IntPtr lpDD;
        public uint dwToGDI;
        public uint dwReserved;
        public HRESULT ddRVal;
        public IntPtr FlipToGDISurface;
    }
}
