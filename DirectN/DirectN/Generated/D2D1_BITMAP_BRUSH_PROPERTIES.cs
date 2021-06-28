// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(329,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes the extend modes and the interpolation mode of an ID2D1BitmapBrush.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_BITMAP_BRUSH_PROPERTIES
    {
        public D2D1_EXTEND_MODE extendModeX;
        public D2D1_EXTEND_MODE extendModeY;
        public D2D1_BITMAP_INTERPOLATION_MODE interpolationMode;
    }
}
