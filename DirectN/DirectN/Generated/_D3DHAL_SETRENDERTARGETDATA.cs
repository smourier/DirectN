// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(653,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_SETRENDERTARGETDATA
    {
        public IntPtr dwhContext;
        public _D3DHAL_SETRENDERTARGETDATA__union_0 __union_1;
        public _D3DHAL_SETRENDERTARGETDATA__union_1 __union_2;
        public HRESULT ddrval;
    }
}
