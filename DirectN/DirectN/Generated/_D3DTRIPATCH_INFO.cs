// generated from <Windows SDK Path>\shared\d3d9types.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DTRIPATCH_INFO
    {
        public uint StartVertexOffset;
        public uint NumVertices;
        public _D3DBASISTYPE Basis;
        public _D3DDEGREETYPE Degree;
    }
}
