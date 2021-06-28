// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1svg.h(538,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents an SVG length.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_SVG_LENGTH
    {
        public float value;
        public D2D1_SVG_LENGTH_UNITS units;
    }
}
