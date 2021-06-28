// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1134,9)
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
