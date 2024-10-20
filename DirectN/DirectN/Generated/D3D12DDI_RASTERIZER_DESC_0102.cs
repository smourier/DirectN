// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RASTERIZER_DESC_0102
    {
        public D3D12DDI_FILL_MODE FillMode;
        public D3D12DDI_CULL_MODE CullMode;
        public bool FrontCounterClockwise;
        public float DepthBias;
        public float DepthBiasClamp;
        public float SlopeScaledDepthBias;
        public bool DepthClipEnable;
        public bool ScissorEnable;
        public D3D12DDI_LINE_RASTERIZATION_MODE LineRasterizationMode;
        public uint ForcedSampleCount;
        public D3D12DDI_CONSERVATIVE_RASTERIZATION_MODE ConservativeRasterizationMode;
        public D3D12DDI_LIBRARY_REFERENCE_0010 LibraryReference;
    }
}
