// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(980,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_SURFACE_INT = DirectN._DD_SURFACE_INT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_VIDEOPORT_LOCAL
    {
        public IntPtr lpDD;
        public _DDVIDEOPORTDESC ddvpDesc;
        public _DDVIDEOPORTINFO ddvpInfo;
        public IntPtr lpSurface;
        public IntPtr lpVBISurface;
        public uint dwNumAutoflip;
        public uint dwNumVBIAutoflip;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
        public IntPtr dwReserved3;
    }
}
