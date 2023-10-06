// generated from <Windows SDK Path>\um\d2d1_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_EFFECT_INPUT_DESCRIPTION
    {
        public IntPtr effect;
        public uint inputIndex;
        public D2D_RECT_F inputRectangle;
    }
}
