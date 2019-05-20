// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(1412,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATECOMMANDALLOCATOR
    {
        public D3D12DDI_HCOMMANDALLOCATOR hDrvCommandAllocator;
        public D3D12DDI_COMMAND_LIST_TYPE Type;
        public D3D12DDI_COMMAND_QUEUE_FLAGS QueueFlags;
    }
}
