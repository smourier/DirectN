// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2730,9)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CREATESURFACEEXDATA
    {
        public uint dwFlags;
        public IntPtr lpDDLcl;
        public IntPtr lpDDSLcl;
        public HRESULT ddRVal;
    }
}
