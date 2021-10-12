// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(493,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Creation properties for an image brush.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_IMAGE_BRUSH_PROPERTIES
    {
        public D2D_RECT_F sourceRectangle;
        public D2D1_EXTEND_MODE extendModeX;
        public D2D1_EXTEND_MODE extendModeY;
        public D2D1_INTERPOLATION_MODE interpolationMode;
    }
}
