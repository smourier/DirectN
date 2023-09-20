// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_GETINTERNALINFO = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETINTERNALMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpGuid;
        public uint dwWidth;
        public uint dwHeight;
        public _DDPIXELFORMAT ddPixelFormat;
        public uint dwScratchMemAlloc;
        public HRESULT ddRVal;
        public IntPtr GetInternalMoCompInfo;
    }
}
