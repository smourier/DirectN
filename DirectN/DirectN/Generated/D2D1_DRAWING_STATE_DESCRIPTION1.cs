// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
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
