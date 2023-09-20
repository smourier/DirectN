// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SHADER_CAPS_0082
    {
        public D3D12DDI_SHADER_MIN_PRECISION MinPrecision;
        public bool DoubleOps;
        public bool ShaderSpecifiedStencilRef;
        public bool TypedUAVLoadAdditionalFormats;
        public bool ROVs;
        public bool WaveOps;
        public uint WaveLaneCountMin;
        public uint WaveLaneCountMax;
        public uint TotalLaneCount;
        public bool Int64Ops;
        public bool Native16BitOps;
        public bool AtomicInt64OnTypedResource;
        public bool AtomicInt64OnGroupShared;
        public bool DerivativesInMeshAndAmplificationShaders;
        public D3D12DDI_WAVE_MMA_TIER WaveMMATier;
    }
}
