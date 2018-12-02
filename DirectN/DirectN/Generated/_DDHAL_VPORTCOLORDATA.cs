// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2603,9)
using System;
using System.Runtime.InteropServices;
using LPDDCOLORCONTROL = DirectN._DDCOLORCONTROL;
using LPDDHALVPORTCB_COLORCONTROL = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_VPORTCOLORDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public uint dwFlags;
        public IntPtr lpColorData;
        public HRESULT ddRVal;
        public IntPtr ColorControl;
    }
}
