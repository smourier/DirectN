// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVOLUME_DESC
    {
        public _D3DFORMAT Format;
        public _D3DRESOURCETYPE Type;
        public uint Usage;
        public _D3DPOOL Pool;
        public uint Width;
        public uint Height;
        public uint Depth;
    }
}
