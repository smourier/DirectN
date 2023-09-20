// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_2DDIARG_GETCAPS
    {
        public D3D10_2DDICAPS_TYPE Type;
        public IntPtr pInfo;
        public IntPtr pData;
        public uint DataSize;
    }
}
