// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(1411,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RASTERIZER_DESC
    {
        public D3D12_FILL_MODE FillMode;
        public D3D12_CULL_MODE CullMode;
        public bool FrontCounterClockwise;
        public int DepthBias;
        public float DepthBiasClamp;
        public float SlopeScaledDepthBias;
        public bool DepthClipEnable;
        public bool MultisampleEnable;
        public bool AntialiasedLineEnable;
        public uint ForcedSampleCount;
        public D3D12_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
    }
}
