// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1327,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_INT = DirectN._DDRAWI_DDRAWSURFACE_INT;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_INT
    {
        public IntPtr lpVtbl;
        public IntPtr lpLcl;
        public IntPtr lpLink;
        public uint dwIntRefCnt;
    }
}
