// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(1978,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_RASTERIZER_DESC
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
    }
}
