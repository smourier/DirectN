// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS1
    {
        public bool WaveOps;
        public uint WaveLaneCountMin;
        public uint WaveLaneCountMax;
        public uint TotalLaneCount;
        public bool ExpandedComputeResourceStates;
        public bool Int64ShaderOps;
    }
}
