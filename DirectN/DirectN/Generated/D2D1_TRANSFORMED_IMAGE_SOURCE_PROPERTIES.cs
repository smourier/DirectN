// generated from <Windows SDK Path>\um\d2d1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES
    {
        public D2D1_ORIENTATION orientation;
        public float scaleX;
        public float scaleY;
        public D2D1_INTERPOLATION_MODE interpolationMode;
        public D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS options;
    }
}
