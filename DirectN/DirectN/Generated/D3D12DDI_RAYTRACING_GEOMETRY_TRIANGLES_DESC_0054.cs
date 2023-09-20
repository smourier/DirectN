// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RAYTRACING_GEOMETRY_TRIANGLES_DESC_0054
    {
        public ulong ColumnMajorTransform3x4;
        public DXGI_FORMAT IndexFormat;
        public DXGI_FORMAT VertexFormat;
        public uint IndexCount;
        public uint VertexCount;
        public ulong IndexBuffer;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_AND_STRIDE VertexBuffer;
    }
}
