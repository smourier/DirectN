// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dnthal.h(452,9)
using System;
using System.Runtime.InteropServices;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_SETRENDERTARGETDATA
    {
        public IntPtr dwhContext;
        public IntPtr lpDDS;
        public IntPtr lpDDSZ;
        public HRESULT ddrval;
    }
}
