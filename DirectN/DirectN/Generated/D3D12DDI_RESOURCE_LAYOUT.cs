// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1500,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_RESOURCE_LAYOUT
    {
        D3D12DDI_RL_UNDEFINED = 0x00000000,
        D3D12DDI_RL_PLACED_PHYSICAL_SUBRESOURCE_PITCHED = 0x00000001,
        D3D12DDI_RL_PLACED_VIRTUAL_SUBRESOURCE_PITCHED = 0x00000002,
        D3D12DDI_RL_SELECT_SUBRESOURCE = 0x00000040,
    }
}
