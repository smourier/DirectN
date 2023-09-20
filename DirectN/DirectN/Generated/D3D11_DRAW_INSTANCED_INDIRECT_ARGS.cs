// generated from <Windows SDK Path>\um\d3d11.h
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
