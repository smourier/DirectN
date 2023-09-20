// generated from <Windows SDK Path>\um\ddrawi.h
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
