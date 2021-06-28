// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2625,9)
using System;
using System.Runtime.InteropServices;
using LPDDCOLORCONTROL = DirectN._DDCOLORCONTROL;
using LPDDHALCOLORCB_COLORCONTROL = System.IntPtr;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDDRAWI_DIRECTDRAW_GBL = DirectN._DDRAWI_DIRECTDRAW_GBL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_COLORCONTROLDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDSurface;
        public IntPtr lpColorData;
        public uint dwFlags;
        public HRESULT ddRVal;
        public IntPtr ColorControl;
    }
}
