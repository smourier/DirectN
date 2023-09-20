// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_DISPATCH_RAYS_0054
    {
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE RayGenerationShaderRecord;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE MissShaderTable;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE HitGroupTable;
        public D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE CallableShaderTable;
        public uint Width;
        public uint Height;
        public uint Depth;
    }
}
