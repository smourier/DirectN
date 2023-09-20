// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_WAITFORVERTICALBLANK = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_WAITFORVERTICALBLANKDATA
    {
        public IntPtr lpDD;
        public uint dwFlags;
        public uint bIsInVB;
        public IntPtr hEvent;
        public HRESULT ddRVal;
        public IntPtr WaitForVerticalBlank;
    }
}
