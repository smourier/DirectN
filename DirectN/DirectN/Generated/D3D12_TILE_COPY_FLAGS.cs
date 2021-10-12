// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2783,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_TILE_COPY_FLAGS
    {
        D3D12_TILE_COPY_FLAG_NONE = 0x00000000,
        D3D12_TILE_COPY_FLAG_NO_HAZARD = 0x00000001,
        D3D12_TILE_COPY_FLAG_LINEAR_BUFFER_TO_SWIZZLED_TILED_RESOURCE = 0x00000002,
        D3D12_TILE_COPY_FLAG_SWIZZLED_TILED_RESOURCE_TO_LINEAR_BUFFER = 0x00000004,
    }
}
