// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(117,9)
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
