// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2556,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_UPDATE = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_INT = DirectN._DDRAWI_DDRAWSURFACE_INT;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTINFO = DirectN._DDVIDEOPORTINFO;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_UPDATEVPORTDATA
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
