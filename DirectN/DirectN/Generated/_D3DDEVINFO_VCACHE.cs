// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_VCACHE
    {
        public uint Pattern;
        public uint OptMethod;
        public uint CacheSize;
        public uint MagicNumber;
    }
}
