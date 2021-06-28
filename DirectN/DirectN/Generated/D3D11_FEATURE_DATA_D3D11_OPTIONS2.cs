// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(7416,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS2
    {
        public bool PSSpecifiedStencilRefSupported;
        public bool TypedUAVLoadAdditionalFormats;
        public bool ROVsSupported;
        public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
        public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
        public bool MapOnDefaultTextures;
        public bool StandardSwizzle;
        public bool UnifiedMemoryArchitecture;
    }
}
