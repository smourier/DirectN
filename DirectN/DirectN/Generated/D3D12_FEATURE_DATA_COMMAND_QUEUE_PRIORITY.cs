// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_COMMAND_QUEUE_PRIORITY
    {
        public D3D12_COMMAND_LIST_TYPE CommandListType;
        public uint Priority;
        public bool PriorityForTypeIsSupported;
    }
}
