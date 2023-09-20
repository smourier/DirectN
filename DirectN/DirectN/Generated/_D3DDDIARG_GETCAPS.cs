// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_GETCAPS
    {
        public _D3DDDICAPS_TYPE Type;
        public IntPtr pInfo;
        public IntPtr pData;
        public uint DataSize;
    }
}
