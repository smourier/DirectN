// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_SETMODE = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETMODEDATA
    {
        public IntPtr lpDD;
        public uint dwModeIndex;
        public HRESULT ddRVal;
        public IntPtr SetMode;
        public bool inexcl;
        public bool useRefreshRate;
    }
}
