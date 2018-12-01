// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(452,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_SETRENDERTARGETDATA
    {
        public ulong dwhContext;
        public IntPtr lpDDS;
        public IntPtr lpDDSZ;
        public HRESULT ddrval;
    }
}
