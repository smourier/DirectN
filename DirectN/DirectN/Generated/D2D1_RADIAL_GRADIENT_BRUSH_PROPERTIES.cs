// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(354,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the gradient origin offset and the size and position of the gradient ellipse for an ID2D1RadialGradientBrush.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES
    {
        public D2D_POINT_2F center;
        public D2D_POINT_2F gradientOriginOffset;
        public float radiusX;
        public float radiusY;
    }
}
