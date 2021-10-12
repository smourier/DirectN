// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(4037,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DRAW_ARGUMENTS
    {
        public uint VertexCountPerInstance;
        public uint InstanceCount;
        public uint StartVertexLocation;
        public uint StartInstanceLocation;
    }
}
