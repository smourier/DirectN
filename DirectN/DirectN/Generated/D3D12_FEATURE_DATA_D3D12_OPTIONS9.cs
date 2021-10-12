// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2515,9)
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
