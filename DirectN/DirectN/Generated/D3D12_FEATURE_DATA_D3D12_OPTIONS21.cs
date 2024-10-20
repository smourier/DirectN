// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS21
    {
        public D3D12_WORK_GRAPHS_TIER WorkGraphsTier;
        public D3D12_EXECUTE_INDIRECT_TIER ExecuteIndirectTier;
        public bool SampleCmpGradientAndBiasSupported;
        public bool ExtendedCommandInfoSupported;
    }
}
