// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(575,9)
using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    /// <summary>
    /// Describes a triangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_TRIANGLE
    {
        public D2D1_POINT_2F point1;
        public D2D1_POINT_2F point2;
        public D2D1_POINT_2F point3;
    }
}
