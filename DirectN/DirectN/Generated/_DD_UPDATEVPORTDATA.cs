// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1586,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_SURFACE_INT = DirectN._DD_SURFACE_INT;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;
using PDD_VIDEOPORTINFO = DirectN._DDVIDEOPORTINFO;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_UPDATEVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public IntPtr lplpDDSurface;
        public IntPtr lplpDDVBISurface;
        public IntPtr lpVideoInfo;
        public uint dwFlags;
        public uint dwNumAutoflip;
        public uint dwNumVBIAutoflip;
        public HRESULT ddRVal;
        public IntPtr UpdateVideoPort;
    }
}
