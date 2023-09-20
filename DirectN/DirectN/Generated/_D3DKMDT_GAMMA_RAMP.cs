// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_GAMMA_RAMP
    {
        public _D3DDDI_GAMMARAMP_TYPE Type;
        public IntPtr DataSize;
        public _D3DKMDT_GAMMA_RAMP__union_0 Data;
    }
}
