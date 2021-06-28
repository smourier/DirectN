// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_3.h(152,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a point, radius pair that makes up part of a D2D1_INK_BEZIER_SEGMENT.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_INK_POINT
    {
        public float x;
        public float y;
        public float radius;
    }
}
