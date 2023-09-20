// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Properties, aside from the width, that allow geometric penning to be specified.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_STROKE_STYLE_PROPERTIES
    {
        public D2D1_CAP_STYLE startCap;
        public D2D1_CAP_STYLE endCap;
        public D2D1_CAP_STYLE dashCap;
        public D2D1_LINE_JOIN lineJoin;
        public float miterLimit;
        public D2D1_DASH_STYLE dashStyle;
        public float dashOffset;
    }
}
