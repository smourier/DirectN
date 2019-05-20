// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmdt.h(322,9)
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
