using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
    {
        public D2D1_POINT_2F startPoint;
        public D2D1_POINT_2F endPoint;
    }
}
