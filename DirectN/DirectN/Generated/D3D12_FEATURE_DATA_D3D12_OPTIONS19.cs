// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS19
    {
        public bool MismatchingOutputDimensionsSupported;
        public uint SupportedSampleCountsWithNoOutputs;
        public bool PointSamplingAddressesNeverRoundUp;
        public bool RasterizerDesc2Supported;
        public bool NarrowQuadrilateralLinesSupported;
        public bool AnisoFilterWithPointMipSupported;
        public uint MaxSamplerDescriptorHeapSize;
        public uint MaxSamplerDescriptorHeapSizeWithStaticSamplers;
        public uint MaxViewDescriptorHeapSize;
        public bool ComputeOnlyCustomHeapSupported;
    }
}
