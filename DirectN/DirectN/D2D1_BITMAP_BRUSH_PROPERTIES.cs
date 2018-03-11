using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_BITMAP_BRUSH_PROPERTIES
    {
        public D2D1_EXTEND_MODE extendModeX;
        public D2D1_EXTEND_MODE extendModeY;
        public D2D1_BITMAP_INTERPOLATION_MODE interpolationMode;
    }
}
