// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALPALCB_DESTROYPALETTE = System.IntPtr;
using LPDDRAWI_DDRAWPALETTE_GBL = DirectN._DDRAWI_DDRAWPALETTE_GBL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DESTROYPALETTEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDPalette;
        public HRESULT ddRVal;
        public IntPtr DestroyPalette;
    }
}
