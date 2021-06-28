// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2867,9)
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
