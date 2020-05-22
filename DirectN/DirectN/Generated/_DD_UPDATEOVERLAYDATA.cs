// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1181,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_UPDATEOVERLAYDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDDestSurface;
        public _RECTL rDest;
        public IntPtr lpDDSrcSurface;
        public _RECTL rSrc;
        public uint dwFlags;
        public _DDOVERLAYFX overlayFX;
        public HRESULT ddRVal;
        public IntPtr UpdateOverlay;
    }
}
