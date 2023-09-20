// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_DRAWINDEXEDPRIMITIVE2
    {
        public int PrimitiveType;
        public int BaseVertexOffset;
        public uint MinIndex;
        public uint NumVertices;
        public uint StartIndexOffset;
        public uint PrimitiveCount;
    }
}
