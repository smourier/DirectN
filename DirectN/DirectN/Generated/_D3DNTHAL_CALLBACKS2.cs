// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;
using LPD3DNTHAL_SETRENDERTARGETCB = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CALLBACKS2
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SetRenderTarget;
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
        public IntPtr dwReserved3;
        public IntPtr dwReserved4;
    }
}
