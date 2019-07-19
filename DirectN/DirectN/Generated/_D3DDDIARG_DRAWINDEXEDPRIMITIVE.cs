// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(323,9)
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
