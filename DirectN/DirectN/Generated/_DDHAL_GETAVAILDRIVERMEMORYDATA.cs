// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2673,9)
using System;
using System.Runtime.InteropServices;
using DDSCAPS = DirectN._DDSCAPS;
using DDSCAPSEX = DirectN._DDSCAPSEX;
using LPDDHAL_GETAVAILDRIVERMEMORY = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETAVAILDRIVERMEMORYDATA
    {
        public IntPtr lpDD;
        public DDSCAPS DDSCaps;
        public uint dwTotal;
        public uint dwFree;
        public HRESULT ddRVal;
        public IntPtr GetAvailDriverMemory;
        public DDSCAPSEX ddsCapsEx;
    }
}
