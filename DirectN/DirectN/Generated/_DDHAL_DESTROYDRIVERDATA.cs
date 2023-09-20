// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_DESTROYDRIVER = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DESTROYDRIVERDATA
    {
        public IntPtr lpDD;
        public HRESULT ddRVal;
        public IntPtr DestroyDriver;
    }
}
