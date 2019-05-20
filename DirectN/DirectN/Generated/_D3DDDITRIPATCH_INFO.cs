// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(940,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDITRIPATCH_INFO
    {
        public uint StartVertexOffset;
        public uint NumVertices;
        public _D3DDDIBASISTYPE Basis;
        public _D3DDDIDEGREETYPE Degree;
    }
}
