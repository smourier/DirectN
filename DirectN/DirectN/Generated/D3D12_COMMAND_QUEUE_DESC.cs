// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_COMMAND_QUEUE_DESC
    {
        public D3D12_COMMAND_LIST_TYPE Type;
        public int Priority;
        public D3D12_COMMAND_QUEUE_FLAGS Flags;
        public uint NodeMask;
    }
}
