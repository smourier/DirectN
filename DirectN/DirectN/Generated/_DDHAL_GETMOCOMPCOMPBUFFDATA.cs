// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHALMOCOMPCB_GETCOMPBUFFINFO = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETMOCOMPCOMPBUFFDATA
    {
        public IntPtr lpDD;
        public IntPtr lpGuid;
        public uint dwWidth;
        public uint dwHeight;
        public _DDPIXELFORMAT ddPixelFormat;
        public uint dwNumTypesCompBuffs;
        public IntPtr lpCompBuffInfo;
        public HRESULT ddRVal;
        public IntPtr GetMoCompBuffInfo;
    }
}
