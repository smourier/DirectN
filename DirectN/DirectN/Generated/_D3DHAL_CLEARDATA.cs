// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(678,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CLEARDATA
    {
        public IntPtr dwhContext;
        public uint dwFlags;
        public uint dwFillColor;
        public uint dwFillDepth;
        public IntPtr lpRects;
        public uint dwNumRects;
        public HRESULT ddrval;
    }
}
