using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_RGBA
    {
        public float r;
        public float g;
        public float b;
        public float a;

        public override string ToString() => "r=" + r + ",g=" + g + ",b=" + b + ",a=" + a;
    }
}
