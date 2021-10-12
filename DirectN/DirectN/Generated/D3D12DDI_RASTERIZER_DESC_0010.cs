// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(3204,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RASTERIZER_DESC_0010
    {
        public D3D12DDI_FILL_MODE FillMode;
        public D3D12DDI_CULL_MODE CullMode;
        public bool FrontCounterClockwise;
        public int DepthBias;
        public float DepthBiasClamp;
        public float SlopeScaledDepthBias;
        public bool DepthClipEnable;
        public bool ScissorEnable;
        public bool MultisampleEnable;
        public bool AntialiasedLineEnable;
        public uint ForcedSampleCount;
        public D3D12DDI_CONSERVATIVE_RASTERIZATION_MODE ConservativeRasterizationMode;
        public D3D12DDI_LIBRARY_REFERENCE_0010 LibraryReference;
    }
}
