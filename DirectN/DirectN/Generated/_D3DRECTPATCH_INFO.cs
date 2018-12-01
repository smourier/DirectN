// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(1792,9)
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
