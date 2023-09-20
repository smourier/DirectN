// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_ADDATTACHEDSURFACEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public IntPtr lpSurfAttached;
        public HRESULT ddRVal;
        public IntPtr AddAttachedSurface;
    }
}
