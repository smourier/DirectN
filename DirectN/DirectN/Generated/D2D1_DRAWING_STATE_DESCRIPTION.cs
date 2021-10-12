// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1.h(936,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Allows the drawing state to be atomically created. This also specifies the drawing state that is saved into an IDrawingStateBlock object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_DRAWING_STATE_DESCRIPTION
    {
        public D2D1_ANTIALIAS_MODE antialiasMode;
        public D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode;
        public ulong tag1;
        public ulong tag2;
        public D2D_MATRIX_3X2_F transform;
    }
}
