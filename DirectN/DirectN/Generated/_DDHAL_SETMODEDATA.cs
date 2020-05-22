// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2350,9)
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
