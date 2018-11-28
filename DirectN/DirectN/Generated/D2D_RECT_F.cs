using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_RECT_F
    {
        public float left;
        public float top;
        public float right;
        public float bottom;
    }
}
