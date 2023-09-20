// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_DESTROYDDLOCALDATA
    {
        public uint dwFlags;
        public IntPtr pDDLcl;
        public HRESULT ddRVal;
    }
}
