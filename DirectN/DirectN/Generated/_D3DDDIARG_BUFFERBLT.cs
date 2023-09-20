// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_BUFFERBLT
    {
        public IntPtr hDstResource;
        public IntPtr hSrcResource;
        public uint Offset;
        public _D3DDDIRANGE SrcRange;
    }
}
