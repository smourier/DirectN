// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(798,9)
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
