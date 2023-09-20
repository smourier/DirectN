// generated from <Windows SDK Path>\um\d2d1.h
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes a cubic bezier in a path.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_BEZIER_SEGMENT
    {
        public D2D_POINT_2F point1;
        public D2D_POINT_2F point2;
        public D2D_POINT_2F point3;
    }
}
