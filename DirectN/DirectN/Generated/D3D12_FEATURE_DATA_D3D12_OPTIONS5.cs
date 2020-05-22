// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2371,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS5
    {
        public bool SRVOnlyTiledResourceTier3;
        public D3D12_RENDER_PASS_TIER RenderPassesTier;
        public D3D12_RAYTRACING_TIER RaytracingTier;
    }
}
