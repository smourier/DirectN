// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(653,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the center point, x-radius, and y-radius of an ellipse.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_ELLIPSE
    {
        public D2D_POINT_2F point;
        public float radiusX;
        public float radiusY;
    }
}
