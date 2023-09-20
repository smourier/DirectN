// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct D3DDISPLAYMODEFILTER
    {
        public uint Size;
        public _D3DFORMAT Format;
        public D3DSCANLINEORDERING ScanLineOrdering;
    }
}
