// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2673,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_GETAVAILDRIVERMEMORY = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETAVAILDRIVERMEMORYDATA
    {
        public IntPtr lpDD;
        public _DDSCAPS DDSCaps;
        public uint dwTotal;
        public uint dwFree;
        public HRESULT ddRVal;
        public IntPtr GetAvailDriverMemory;
        public _DDSCAPSEX ddsCapsEx;
    }
}
