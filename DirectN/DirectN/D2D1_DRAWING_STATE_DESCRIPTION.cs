using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_TAG = System.UInt64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_DRAWING_STATE_DESCRIPTION
    {
        public D2D1_ANTIALIAS_MODE antialiasMode;
        public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;
        public D2D1_TAG tag1;
        public D2D1_TAG tag2;
        public D2D1_MATRIX_3X2_F transform;
    }
}
