// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATE_COMMAND_LIST_0001
    {
        public D3D12DDI_HCOMMANDLIST hDrvCommandList;
        public D3D12DDI_HRTCOMMANDLIST hRTCommandList;
        public D3D12DDI_HCOMMANDALLOCATOR hDrvCommandAllocator;
        public D3D12DDI_COMMAND_LIST_TYPE Type;
        public D3D12DDI_COMMAND_QUEUE_FLAGS QueueFlags;
        public ulong ID;
        public D3D12DDI_COMMAND_LIST_FLAGS CommandListFlags;
        public uint NodeMask;
    }
}
