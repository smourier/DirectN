// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS9
    {
        public bool MeshShaderPipelineStatsSupported;
        public bool MeshShaderSupportsFullRangeRenderTargetArrayIndex;
        public bool AtomicInt64OnTypedResourceSupported;
        public bool AtomicInt64OnGroupSharedSupported;
        public bool DerivativesInMeshAndAmplificationShadersSupported;
        public D3D12_WAVE_MMA_TIER WaveMMATier;
    }
}
