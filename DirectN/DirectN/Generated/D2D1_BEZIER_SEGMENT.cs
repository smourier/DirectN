// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(563,9)
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
