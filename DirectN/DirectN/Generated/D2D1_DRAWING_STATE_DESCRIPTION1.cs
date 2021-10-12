// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(595,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This describes the drawing state.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_DRAWING_STATE_DESCRIPTION1
    {
        public D2D1_ANTIALIAS_MODE antialiasMode;
        public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;
        public ulong tag1;
        public ulong tag2;
        public D2D_MATRIX_3X2_F transform;
        public D2D1_PRIMITIVE_BLEND primitiveBlend;
        public D2D1_UNIT_MODE unitMode;
    }
}
