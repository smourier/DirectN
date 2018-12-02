// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1197,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SETOVERLAYPOSITIONDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSrcSurface;
        public IntPtr lpDDDestSurface;
        public int lXPos;
        public int lYPos;
        public HRESULT ddRVal;
        public IntPtr SetOverlayPosition;
    }
}
