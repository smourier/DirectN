// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dnthal.h(464,9)
using System;
using System.Runtime.InteropServices;
using LPD3DNTHAL_SETRENDERTARGETCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CALLBACKS2
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SetRenderTarget;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
        public IntPtr dwReserved3;
        public IntPtr dwReserved4;
    }
}
