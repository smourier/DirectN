// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_GETSCANLINE = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETSCANLINEDATA
    {
        public IntPtr lpDD;
        public uint dwScanLine;
        public HRESULT ddRVal;
        public IntPtr GetScanLine;
    }
}
