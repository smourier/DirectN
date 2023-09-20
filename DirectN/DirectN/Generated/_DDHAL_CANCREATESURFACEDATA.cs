// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDHAL_CANCREATESURFACE = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CANCREATESURFACEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurfaceDesc;
        public uint bIsDifferentPixelFormat;
        public HRESULT ddRVal;
        public IntPtr CanCreateSurface;
    }
}
