// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dnthal.h(480,9)
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
