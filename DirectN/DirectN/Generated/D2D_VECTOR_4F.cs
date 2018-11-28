using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_VECTOR_4F
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }
}
