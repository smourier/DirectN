using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_PRESENT_PARAMETERS
    {
        int DirtyRectsCount;
        IntPtr pDirtyRects;
        IntPtr pScrollRect;
        IntPtr pScrollOffset;
    }
}
