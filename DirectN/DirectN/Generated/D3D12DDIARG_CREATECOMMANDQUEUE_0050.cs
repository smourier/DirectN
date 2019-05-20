// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(6837,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATECOMMANDQUEUE_0050
    {
        public D3D12DDI_COMMAND_QUEUE_FLAGS QueueFlags;
        public uint NodeMask;
        public D3D12DDI_COMMAND_QUEUE_CREATION_FLAGS QueueCreationFlags;
        public D3D12DDI_HSCHEDULINGGROUP_0050 SchedulingGroup;
    }
}
