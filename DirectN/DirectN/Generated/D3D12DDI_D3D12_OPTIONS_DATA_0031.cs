// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(6057,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_D3D12_OPTIONS_DATA_0031
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
    }
}
