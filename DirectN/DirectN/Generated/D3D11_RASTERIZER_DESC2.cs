// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(638,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_RASTERIZER_DESC2
    {
        public D3D11_FILL_MODE FillMode;
        public D3D11_CULL_MODE CullMode;
        public bool FrontCounterClockwise;
        public int DepthBias;
        public float DepthBiasClamp;
        public float SlopeScaledDepthBias;
        public bool DepthClipEnable;
        public bool ScissorEnable;
        public bool MultisampleEnable;
        public bool AntialiasedLineEnable;
        public uint ForcedSampleCount;
        public D3D11_CONSERVATIVE_RASTERIZATION_MODE ConservativeRaster;
    }
}
