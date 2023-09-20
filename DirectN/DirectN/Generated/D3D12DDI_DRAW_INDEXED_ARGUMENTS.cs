// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DRAW_INDEXED_ARGUMENTS
    {
        public uint IndexCountPerInstance;
        public uint InstanceCount;
        public uint StartIndexLocation;
        public int BaseVertexLocation;
        public uint StartInstanceLocation;
    }
}
