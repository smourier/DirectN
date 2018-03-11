using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_MATRIX_4X3_F
    {
        public float _11, _12, _13;
        public float _21, _22, _23;
        public float _31, _32, _33;
        public float _41, _42, _43;
    }
}
