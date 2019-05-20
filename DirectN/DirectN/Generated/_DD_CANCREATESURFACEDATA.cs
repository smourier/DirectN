// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawint.h(1361,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_CANCREATESURFACEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurfaceDesc;
        public uint bIsDifferentPixelFormat;
        public HRESULT ddRVal;
        public IntPtr CanCreateSurface;
    }
}
