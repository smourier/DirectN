// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIRECTPATCH_INFO
    {
        public uint StartVertexOffsetWidth;
        public uint StartVertexOffsetHeight;
        public uint Width;
        public uint Height;
        public uint Stride;
        public _D3DDDIBASISTYPE Basis;
        public _D3DDDIDEGREETYPE Degree;
    }
}
