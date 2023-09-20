// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_MOTIONCOMP_LOCAL = DirectN._DD_MOTIONCOMP_LOCAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_QUERYMOCOMPSTATUSDATA
    {
        public IntPtr lpDD;
        public IntPtr lpMoComp;
        public IntPtr lpSurface;
        public uint dwFlags;
        public HRESULT ddRVal;
    }
}
