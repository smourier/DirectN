// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1_1.h(451,9)
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
