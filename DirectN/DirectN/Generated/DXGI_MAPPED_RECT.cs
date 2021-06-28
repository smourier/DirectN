// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi.h(178,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_MAPPED_RECT
    {
        public int Pitch;
        public IntPtr pBits;
    }
}
