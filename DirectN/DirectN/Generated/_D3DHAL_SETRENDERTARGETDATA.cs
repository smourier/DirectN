// generated from <Windows SDK Path>\um\d3dhal.h
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
