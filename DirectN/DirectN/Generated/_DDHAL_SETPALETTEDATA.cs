// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2148,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALSURFCB_SETPALETTE = System.IntPtr;
using LPDDRAWI_DDRAWPALETTE_GBL = DirectN._DDRAWI_DDRAWPALETTE_GBL;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETPALETTEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public IntPtr lpDDPalette;
        public HRESULT ddRVal;
        public IntPtr SetPalette;
        public bool Attach;
    }
}
