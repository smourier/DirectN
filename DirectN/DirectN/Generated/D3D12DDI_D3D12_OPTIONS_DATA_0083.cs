// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(10363,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_D3D12_OPTIONS_DATA_0083
    {
        public D3D12DDI_RESOURCE_BINDING_TIER ResourceBindingTier;
        public D3D12DDI_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
        public D3D12DDI_TILED_RESOURCES_TIER TiledResourcesTier;
        public D3D12DDI_CROSS_NODE_SHARING_TIER CrossNodeSharingTier;
        public bool VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;
        public bool OutputMergerLogicOp;
        public D3D12DDI_RESOURCE_HEAP_TIER ResourceHeapTier;
        public bool DepthBoundsTestSupported;
        public D3D12DDI_PROGRAMMABLE_SAMPLE_POSITIONS_TIER ProgrammableSamplePositionsTier;
        public bool CopyQueueTimestampQueriesSupported;
        public D3D12DDI_COMMAND_QUEUE_FLAGS WriteBufferImmediateQueueFlags;
        public D3D12DDI_VIEW_INSTANCING_TIER ViewInstancingTier;
        public bool BarycentricsSupported;
        public bool ReservedBufferPlacementSupported;
        public bool Deterministic64KBUndefinedSwizzle;
        public bool SRVOnlyTiledResourceTier3;
        public D3D12DDI_RENDER_PASS_TIER RenderPassTier;
        public D3D12DDI_RAYTRACING_TIER RaytracingTier;
        public D3D12DDI_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;
        public bool PerPrimitiveShadingRateSupportedWithViewportIndexing;
        public bool AdditionalShadingRatesSupported;
        public uint ShadingRateImageTileSize;
        public bool BackgroundProcessingSupported;
        public D3D12DDI_MESH_SHADER_TIER MeshShaderTier;
        public D3D12DDI_SAMPLER_FEEDBACK_TIER SamplerFeedbackTier;
        public bool DriverManagedShaderCachePresent;
        public bool MeshShaderSupportsFullRangeRenderTargetArrayIndex;
        public bool VariableRateShadingSumCombinerSupported;
        public bool MeshShaderPerPrimitiveShadingRateSupported;
    }
}
