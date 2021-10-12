// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_3.h(166,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents a Bezier segment to be used in the creation of an ID2D1Ink object. This structure differs from D2D1_BEZIER_SEGMENT in that it is composed of D2D1_INK_POINT s, which contain a radius in addition to x- and y-coordinates.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_INK_BEZIER_SEGMENT
    {
        public D2D1_INK_POINT point1;
        public D2D1_INK_POINT point2;
        public D2D1_INK_POINT point3;
    }
}
