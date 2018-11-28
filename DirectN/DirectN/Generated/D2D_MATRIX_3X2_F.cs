using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_3X2_F
    {
        public float _11, _12;
        public float _21, _22;
        public float _31, _32;
    }
}
