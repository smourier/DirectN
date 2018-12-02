// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2452,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_GETBANDWIDTH = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTBANDWIDTH = DirectN._DDVIDEOPORTBANDWIDTH;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETVPORTBANDWIDTHDATA
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
