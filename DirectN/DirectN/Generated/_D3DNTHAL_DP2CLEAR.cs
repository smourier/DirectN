// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_DP2CLEAR
    {
        public uint dwFlags;
        public uint dwFillColor;
        public float dvFillDepth;
        public uint dwFillStencil;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public tagRECT[] Rects;
    }
}
