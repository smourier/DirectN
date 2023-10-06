// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SYNCSURFACEDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public uint dwSurfaceOffset;
        public IntPtr fpLockPtr;
        public int lPitch;
        public uint dwOverlayOffset;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
        public uint dwDriverReserved4;
        public HRESULT ddRVal;
    }
}
