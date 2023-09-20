// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_D3D9_OPTIONS1
    {
        public bool FullNonPow2TextureSupported;
        public bool DepthAsTextureWithLessEqualComparisonFilterSupported;
        public bool SimpleInstancingSupported;
        public bool TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
    }
}
