using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_MAPPED_RECT
    {
        public int pitch;
        public IntPtr bits;
    }
}
