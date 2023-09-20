// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_CROSS_NODE
    {
        public D3D12_CROSS_NODE_SHARING_TIER SharingTier;
        public bool AtomicShaderInstructions;
    }
}
