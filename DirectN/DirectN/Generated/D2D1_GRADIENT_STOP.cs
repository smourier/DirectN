// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the position and color of a gradient stop.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_GRADIENT_STOP
    {
        public float position;
        public _D3DCOLORVALUE color;
    }
}
