using System;
using System.Runtime.InteropServices;
using D2D1_SIZE_U = DirectN.D2D_SIZE_U;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D1_HWND_RENDER_TARGET_PROPERTIES
    {
        public IntPtr hwnd;
        public D2D1_SIZE_U pixelSize;
        public D2D1_PRESENT_OPTIONS presentOptions;
    }
}
