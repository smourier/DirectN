// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTBANDWIDTH = DirectN._DDVIDEOPORTBANDWIDTH;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_GETVPORTBANDWIDTHDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public IntPtr lpddpfFormat;
        public uint dwWidth;
        public uint dwHeight;
        public uint dwFlags;
        public IntPtr lpBandwidth;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortBandwidth;
    }
}
