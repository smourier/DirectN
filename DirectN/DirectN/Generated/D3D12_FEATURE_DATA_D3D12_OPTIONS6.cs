// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2463,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS6
    {
        public bool AdditionalShadingRatesSupported;
        public bool PerPrimitiveShadingRateSupportedWithViewportIndexing;
        public D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;
        public uint ShadingRateImageTileSize;
        public bool BackgroundProcessingSupported;
    }
}
