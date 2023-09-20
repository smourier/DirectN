// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVERTEXELEMENT9
    {
        public ushort Stream;
        public ushort Offset;
        public byte Type;
        public byte Method;
        public byte Usage;
        public byte UsageIndex;
    }
}
