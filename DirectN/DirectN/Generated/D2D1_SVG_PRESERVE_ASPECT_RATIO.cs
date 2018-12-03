// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1svg.h(549,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_SVG_PRESERVE_ASPECT_RATIO
    {
        public bool defer;
        public D2D1_SVG_ASPECT_ALIGN align;
        public D2D1_SVG_ASPECT_SCALING meetOrSlice;
    }
}
