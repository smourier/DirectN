// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(929,9)
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
