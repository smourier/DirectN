// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(1558,9)
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
