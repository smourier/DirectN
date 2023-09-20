// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLOCKED_RECT_32
    {
        public int Pitch;
        public IntPtr pBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DLOCKED_RECT_64
    {
        public int Pitch;
        public IntPtr pBits;
    }
}
