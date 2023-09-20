// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_CREATECOMMANDQUEUE_0001
    {
        public D3D12DDI_HCOMMANDQUEUE hDrvCommandQueue;
        public D3D12DDI_HRTCOMMANDQUEUE hRTCommandQueue;
        public D3D12DDI_COMMAND_QUEUE_FLAGS QueueFlags;
        public uint NodeMask;
    }
}
