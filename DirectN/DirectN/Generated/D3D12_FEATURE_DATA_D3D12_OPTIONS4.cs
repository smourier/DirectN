// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2329,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS4
    {
        public bool MSAA64KBAlignedTextureSupported;
        public D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER SharedResourceCompatibilityTier;
        public bool Native16BitShaderOpsSupported;
    }
}
