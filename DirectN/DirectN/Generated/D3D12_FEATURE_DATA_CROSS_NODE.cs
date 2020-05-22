// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2349,9)
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
