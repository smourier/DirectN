// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1445,9)
using System;
using System.Runtime.InteropServices;
using LPDDVIDEOPORTDESC = DirectN._DDVIDEOPORTDESC;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    /// <summary>
    /// **************************************************************************
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_CANCREATEVPORTDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDVideoPortDesc;
        public HRESULT ddRVal;
        public IntPtr CanCreateVideoPort;
    }
}
