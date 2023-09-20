// generated from <Windows SDK Path>\um\ddrawint.h
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
