using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_MATRIX
    {
        public float m11;
        public float m12;
        public float m21;
        public float m22;
        public float dx;
        public float dy;
    };
}
