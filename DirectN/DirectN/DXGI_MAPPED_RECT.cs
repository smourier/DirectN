using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_MAPPED_RECT
    {
        public int Pitch;
        public IntPtr pBits;
    }
}
