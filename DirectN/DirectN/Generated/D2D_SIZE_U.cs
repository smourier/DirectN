// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dcommon.h(264,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Stores an ordered pair of integers, typically the width and height of a rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D_SIZE_U
    {
        public uint width;
        public uint height;
    }
}
