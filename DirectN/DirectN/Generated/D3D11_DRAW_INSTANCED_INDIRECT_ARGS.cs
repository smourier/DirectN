// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(1141,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS
    {
        public uint VertexCountPerInstance;
        public uint InstanceCount;
        public uint StartVertexLocation;
        public uint StartInstanceLocation;
    }
}
