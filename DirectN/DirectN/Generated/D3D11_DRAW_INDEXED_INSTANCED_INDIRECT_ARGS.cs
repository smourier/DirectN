// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(1157,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS
    {
        public uint IndexCountPerInstance;
        public uint InstanceCount;
        public uint StartIndexLocation;
        public int BaseVertexLocation;
        public uint StartInstanceLocation;
    }
}
