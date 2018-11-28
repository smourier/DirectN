using System.Runtime.InteropServices;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_EFFECT_INPUT_DESCRIPTION
    {
        public ID2D1Effect effect;
        public int inputIndex;
        public D2D1_RECT_F inputRectangle;
    }
}
