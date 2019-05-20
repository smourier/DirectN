// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddrawi.h(2427,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_CREATEVIDEOPORT = System.IntPtr;
using LPDDRAWI_DDVIDEOPORT_LCL = DirectN._DDRAWI_DDVIDEOPORT_LCL;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CREATEVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDVideoPortDesc;
        public IntPtr lpVideoPort;
        public HRESULT ddRVal;
        public IntPtr CreateVideoPort;
    }
}
