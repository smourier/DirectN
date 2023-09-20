// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_SETEXCLUSIVEMODE = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_SETEXCLUSIVEMODEDATA
    {
        public IntPtr lpDD;
        public uint dwEnterExcl;
        public uint dwReserved;
        public HRESULT ddRVal;
        public IntPtr SetExclusiveMode;
    }
}
