using System.Runtime.InteropServices;
using D2D1_COLOR_F = DirectN.D3DCOLORVALUE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_GRADIENT_STOP
    {
        public float position;
        public D2D1_COLOR_F color;
    }
}
