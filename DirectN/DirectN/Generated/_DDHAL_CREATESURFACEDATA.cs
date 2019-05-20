// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2284,9)
using System;
using System.Runtime.InteropServices;
using LPDDHAL_CREATESURFACE = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CREATESURFACEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurfaceDesc;
        public IntPtr lplpSList;
        public uint dwSCnt;
        public HRESULT ddRVal;
        public IntPtr CreateSurface;
    }
}
