// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddrawint.h(1223,9)
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_FLIPDATA
    {
        public IntPtr lpDD;
        public IntPtr lpSurfCurr;
        public IntPtr lpSurfTarg;
        public uint dwFlags;
        public HRESULT ddRVal;
        public IntPtr Flip;
        public IntPtr lpSurfCurrLeft;
        public IntPtr lpSurfTargLeft;
    }
}
