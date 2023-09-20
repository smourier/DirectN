// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALPALCB_SETENTRIES = System.IntPtr;
using LPDDRAWI_DDRAWPALETTE_GBL = DirectN._DDRAWI_DDRAWPALETTE_GBL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETENTRIESDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDPalette;
        public uint dwBase;
        public uint dwNumEntries;
        public IntPtr lpEntries;
        public HRESULT ddRVal;
        public IntPtr SetEntries;
    }
}
