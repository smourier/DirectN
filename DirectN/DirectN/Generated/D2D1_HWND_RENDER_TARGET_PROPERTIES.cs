// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(902,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES
    {
        public IntPtr hwnd;
        public D2D_SIZE_U pixelSize;
        public D2D1_PRESENT_OPTIONS presentOptions;
    }
}
