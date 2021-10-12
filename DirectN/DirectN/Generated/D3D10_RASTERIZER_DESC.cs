// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10.h(1362,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_RASTERIZER_DESC
    {
        public D3D10_FILL_MODE FillMode;
        public D3D10_CULL_MODE CullMode;
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
