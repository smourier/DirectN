﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_NODE_IO_FLAGS_0108
    {
        D3D12DDI_NODE_IO_FLAG_INPUT = 0x00000001,
        D3D12DDI_NODE_IO_FLAG_OUTPUT = 0x00000002,
        D3D12DDI_NODE_IO_FLAG_READ_WRITE = 0x00000004,
        D3D12DDI_NODE_IO_FLAG_EMPTY_RECORD = 0x00000008,
        D3D12DDI_NODE_IO_FLAG_NODE_ARRAY = 0x00000010,
        D3D12DDI_NODE_IO_FLAG_THREAD_RECORD = 0x00000020,
        D3D12DDI_NODE_IO_FLAG_GROUP_RECORD = 0x00000040,
        D3D12DDI_NODE_IO_FLAG_DISPATCH_RECORD = 0x00000060,
        D3D12DDI_NODE_IO_FLAG_RECORD_GRANULARITY_MASK = 0x00000060,
        D3D12DDI_NODE_IO_FLAG_KIND_MASK = 0x0000007F,
        D3D12DDI_NODE_IO_FLAG_TRACK_RW_INPUT_SHARING = 0x00000100,
        D3D12DDI_NODE_IO_FLAG_NODE_FLAGS_MASK = 0x00000100,
        D3D12DDI_NODE_IO_FLAG_RECORD_FLAGS_MASK = 0x00000100,
    }
}
