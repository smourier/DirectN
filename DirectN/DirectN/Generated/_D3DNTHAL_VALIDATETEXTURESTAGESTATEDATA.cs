// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dnthal.h(499,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_VALIDATETEXTURESTAGESTATEDATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public IntPtr dwReserved;
        public uint dwNumPasses;
        public HRESULT ddrval;
    }
}
