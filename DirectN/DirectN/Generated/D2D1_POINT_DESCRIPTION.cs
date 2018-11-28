using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_POINT_DESCRIPTION
    {
        public D2D1_POINT_2F point;
        public D2D1_POINT_2F unitTangentVector;
        public int endSegment;
        public int endFigure;
        public float lengthToEndSegment;
    }
}
