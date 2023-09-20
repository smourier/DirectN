// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_FENCE
    {
        public D3D12DDI_FENCE_PLACEMENT FenceValue;
        public D3D12DDI_FENCE_PLACEMENT FenceMonitoredValue;
        public D3D12DDI_FENCE_FLAGS Flags;
    }
}
