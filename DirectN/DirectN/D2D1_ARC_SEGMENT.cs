using System.Runtime.InteropServices;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;
using D2D1_SIZE_F = DirectN.D2D_SIZE_F;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_ARC_SEGMENT
    {
        public D2D1_POINT_2F point;
        public D2D1_SIZE_F size;
        public float rotationAngle;
        public D2D1_SWEEP_DIRECTION sweepDirection;
        public D2D1_ARC_SIZE arcSize;
    }
}
