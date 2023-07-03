// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawi.h(2297,9)
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
