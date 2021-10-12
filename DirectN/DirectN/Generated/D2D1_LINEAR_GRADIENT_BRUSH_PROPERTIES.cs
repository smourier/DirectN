// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(342,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the starting point and endpoint of the gradient axis for an ID2D1LinearGradientBrush.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
    {
        public D2D_POINT_2F startPoint;
        public D2D_POINT_2F endPoint;
    }
}
