// generated from <Windows SDK Path>\um\d2d1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Contains the HWND, pixel size, and presentation options for an ID2D1HwndRenderTarget.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_HWND_RENDER_TARGET_PROPERTIES
    {
        public IntPtr hwnd;
        public D2D_SIZE_U pixelSize;
        public D2D1_PRESENT_OPTIONS presentOptions;
    }
}
