// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddrawint.h(1563,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;
using PDD_VIDEOPORT_LOCAL = DirectN._DD_VIDEOPORT_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DESTROYVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpVideoPort;
        public HRESULT ddRVal;
        public IntPtr DestroyVideoPort;
    }
}
