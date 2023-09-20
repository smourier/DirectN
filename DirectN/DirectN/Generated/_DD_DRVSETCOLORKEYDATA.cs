// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DRVSETCOLORKEYDATA
    {
        public IntPtr lpDDSurface;
        public uint dwFlags;
        public _DDCOLORKEY ckNew;
        public HRESULT ddRVal;
        public IntPtr SetColorKey;
    }
}
