// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the dimensions and corner radii of a rounded rectangle.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_ROUNDED_RECT
    {
        public D2D_RECT_F rect;
        public float radiusX;
        public float radiusY;
    }
}
