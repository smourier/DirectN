﻿// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_STROKE_STYLE_PROPERTIES1
    {
        public D2D1_CAP_STYLE startCap;
        public D2D1_CAP_STYLE endCap;
        public D2D1_CAP_STYLE dashCap;
        public D2D1_LINE_JOIN lineJoin;
        public float miterLimit;
        public D2D1_DASH_STYLE dashStyle;
        public float dashOffset;
        public D2D1_STROKE_TRANSFORM_TYPE transformType;
    }
}
