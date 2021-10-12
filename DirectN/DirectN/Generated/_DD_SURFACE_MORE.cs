// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(774,9)
using System;
using System.Runtime.InteropServices;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_MORE
    {
        public uint dwMipMapCount;
        public IntPtr lpVideoPort;
        public uint dwOverlayFlags;
        public _DDSCAPSEX ddsCapsEx;
        public uint dwSurfaceHandle;
    }
}
