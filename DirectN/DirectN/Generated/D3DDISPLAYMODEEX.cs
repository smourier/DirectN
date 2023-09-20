// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct D3DDISPLAYMODEEX
    {
        public uint Size;
        public uint Width;
        public uint Height;
        public uint RefreshRate;
        public _D3DFORMAT Format;
        public D3DSCANLINEORDERING ScanLineOrdering;
    }
}
