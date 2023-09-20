// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DRECTPATCH_INFO
    {
        public uint StartVertexOffsetWidth;
        public uint StartVertexOffsetHeight;
        public uint Width;
        public uint Height;
        public uint Stride;
        public _D3DBASISTYPE Basis;
        public _D3DDEGREETYPE Degree;
    }
}
