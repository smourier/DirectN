using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BRUSH_PROPERTIES
    {
        public float opacity;
        public D2D1_MATRIX_3X2_F transform;
    }
}
