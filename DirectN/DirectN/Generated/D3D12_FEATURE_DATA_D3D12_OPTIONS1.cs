// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2172,9)
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
