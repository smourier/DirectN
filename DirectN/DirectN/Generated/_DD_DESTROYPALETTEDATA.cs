// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_PALETTE_GLOBAL = DirectN._DD_PALETTE_GLOBAL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DESTROYPALETTEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDPalette;
        public HRESULT ddRVal;
        public IntPtr DestroyPalette;
    }
}
