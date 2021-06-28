// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawi.h(2416,9)
using System;
using System.Runtime.InteropServices;
using LPDDHALVPORTCB_CANCREATEVIDEOPORT = System.IntPtr;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDHAL_CANCREATEVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDVideoPortDesc;
        public HRESULT ddRVal;
        public IntPtr CanCreateVideoPort;
    }
}
