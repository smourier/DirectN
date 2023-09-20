// generated from <Windows SDK Path>\shared\dxgi1_2.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_PRESENT_PARAMETERS
    {
        public uint DirtyRectsCount;
        public IntPtr pDirtyRects;
        public IntPtr pScrollRect;
        public IntPtr pScrollOffset;
    }
}
