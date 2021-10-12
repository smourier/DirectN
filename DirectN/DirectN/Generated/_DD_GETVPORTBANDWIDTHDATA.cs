// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddrawint.h(1481,9)
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
