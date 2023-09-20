// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_CREATE = System.IntPtr;
using LPDDRAWI_DDMOTIONCOMP_LCL = DirectN._DDRAWI_DDMOTIONCOMP_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CREATEMOCOMPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpGuid;
        public uint dwUncompWidth;
        public uint dwUncompHeight;
        public _DDPIXELFORMAT ddUncompPixelFormat;
        public IntPtr lpData;
        public uint dwDataSize;
        public HRESULT ddRVal;
        public IntPtr CreateMoComp;
    }
}
