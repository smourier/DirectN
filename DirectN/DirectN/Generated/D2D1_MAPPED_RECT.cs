// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(421,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes mapped memory from the ID2D1Bitmap1::Map API.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_MAPPED_RECT
    {
        public uint pitch;
        public IntPtr bits;
    }
}
