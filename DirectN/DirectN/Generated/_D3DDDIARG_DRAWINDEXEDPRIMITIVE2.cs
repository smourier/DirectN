// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(350,9)
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
