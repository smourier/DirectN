// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDPN_SOURCE_MODE
    {
        public uint Id;
        public _D3DKMDT_VIDPN_SOURCE_MODE_TYPE Type;
        public _D3DKMDT_VIDPN_SOURCE_MODE__union_0 Format;
    }
}
