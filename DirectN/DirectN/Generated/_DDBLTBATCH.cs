// generated from <Windows SDK Path>\um\ddraw.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDBLTBATCH
    {
        public IntPtr lprDest;
        public IntPtr lpDDSSrc;
        public IntPtr lprSrc;
        public uint dwFlags;
        public IntPtr lpDDBltFx;
    }
}
