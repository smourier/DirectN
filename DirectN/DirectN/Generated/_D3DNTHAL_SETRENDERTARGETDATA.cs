// generated from <Windows SDK Path>\um\d3dnthal.h
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
