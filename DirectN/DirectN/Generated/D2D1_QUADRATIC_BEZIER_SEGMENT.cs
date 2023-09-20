// generated from <Windows SDK Path>\um\d2d1.h
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the control point and end point for a quadratic Bezier segment.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_QUADRATIC_BEZIER_SEGMENT
    {
        public D2D_POINT_2F point1;
        public D2D_POINT_2F point2;
    }
}
