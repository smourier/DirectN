// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2883,9)
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
