// generated from <Windows SDK Path>\um\d3d12.h
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
