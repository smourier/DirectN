﻿// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_POINT_DESCRIPTION
    {
        public D2D_POINT_2F point;
        public D2D_POINT_2F unitTangentVector;
        public uint endSegment;
        public uint endFigure;
        public float lengthToEndSegment;
    }
}
