// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(2497,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_GETFIELD = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_GETVPORTFIELDDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public bool bField;
        public HRESULT ddRVal;
        public IntPtr GetVideoPortField;
    }
}
