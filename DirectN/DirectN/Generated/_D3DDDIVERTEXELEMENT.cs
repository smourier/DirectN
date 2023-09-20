// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIVERTEXELEMENT
    {
        public ushort Stream;
        public ushort Offset;
        public byte Type;
        public byte Method;
        public byte Usage;
        public byte UsageIndex;
    }
}
