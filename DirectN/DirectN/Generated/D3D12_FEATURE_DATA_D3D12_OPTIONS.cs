// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2153,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS
    {
        public bool DoublePrecisionFloatShaderOps;
        public bool OutputMergerLogicOp;
        public D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport;
        public D3D12_TILED_RESOURCES_TIER TiledResourcesTier;
        public D3D12_RESOURCE_BINDING_TIER ResourceBindingTier;
        public bool PSSpecifiedStencilRefSupported;
        public bool TypedUAVLoadAdditionalFormats;
        public bool ROVsSupported;
        public D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
        public uint MaxGPUVirtualAddressBitsPerResource;
        public bool StandardSwizzle64KBSupported;
        public D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier;
        public bool CrossAdapterRowMajorTextureSupported;
        public bool VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;
        public D3D12_RESOURCE_HEAP_TIER ResourceHeapTier;
    }
}
