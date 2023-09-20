// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DRAWINDEXEDPRIMITIVE
    {
        public int PrimitiveType;
        public int BaseVertexIndex;
        public uint MinIndex;
        public uint NumVertices;
        public uint StartIndex;
        public uint PrimitiveCount;
    }
}
