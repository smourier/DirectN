// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(318,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Describes the opacity and transformation of a brush.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_BRUSH_PROPERTIES
    {
        public float opacity;
        public D2D_MATRIX_3X2_F transform;
    }
}
