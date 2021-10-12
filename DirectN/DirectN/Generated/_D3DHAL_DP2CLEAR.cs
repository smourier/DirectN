// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(1235,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_DP2CLEAR
    {
        public uint dwFlags;
        public uint dwFillColor;
        public float dvFillDepth;
        public uint dwFillStencil;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagRECT[] Rects;
    }
}
