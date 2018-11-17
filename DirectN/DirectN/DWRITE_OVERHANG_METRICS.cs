using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_OVERHANG_METRICS
    {
        public float left;
        public float top;
        public float right;
        public float bottom;
    }
}
