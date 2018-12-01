// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(851,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_VALIDATETEXTURESTAGESTATEDATA
    {
        public ulong dwhContext;
        public uint dwFlags;
        public ulong dwReserved;
        public uint dwNumPasses;
        public HRESULT ddrval;
    }
}
