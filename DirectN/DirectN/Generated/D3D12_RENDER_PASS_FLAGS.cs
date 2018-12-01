// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(14201,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_RENDER_PASS_FLAGS
    {
        D3D12_RENDER_PASS_FLAG_NONE = 0x00000000,
        D3D12_RENDER_PASS_FLAG_ALLOW_UAV_WRITES = 0x00000001,
        D3D12_RENDER_PASS_FLAG_SUSPENDING_PASS = 0x00000002,
        D3D12_RENDER_PASS_FLAG_RESUMING_PASS = 0x00000004,
    }
}
