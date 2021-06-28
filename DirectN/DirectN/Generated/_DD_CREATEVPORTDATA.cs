// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1456,9)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_CREATEVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDVideoPortDesc;
        public IntPtr lpVideoPort;
        public HRESULT ddRVal;
        public IntPtr CreateVideoPort;
    }
}
