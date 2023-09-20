// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CLEAR2DATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public uint dwFillColor;
        public float dvFillDepth;
        public uint dwFillStencil;
        public IntPtr lpRects;
        public uint dwNumRects;
        public HRESULT ddrval;
    }
}
