// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2309,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_CREATEPALETTE = System.IntPtr;
using LPDDRAWI_DDRAWPALETTE_GBL = DirectN._DDRAWI_DDRAWPALETTE_GBL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CREATEPALETTEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDPalette;
        public IntPtr lpColorTable;
        public HRESULT ddRVal;
        public IntPtr CreatePalette;
        public bool is_excl;
    }
}
