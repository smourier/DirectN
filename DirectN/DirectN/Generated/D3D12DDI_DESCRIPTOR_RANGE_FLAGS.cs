﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_DESCRIPTOR_RANGE_FLAGS
    {
        D3D12DDI_DESCRIPTOR_RANGE_FLAG_0013_NONE = 0x00000000,
        D3D12DDI_DESCRIPTOR_RANGE_FLAG_0013_DESCRIPTORS_VOLATILE = 0x00000001,
        D3D12DDI_DESCRIPTOR_RANGE_FLAG_0013_DATA_VOLATILE = 0x00000002,
        D3D12DDI_DESCRIPTOR_RANGE_FLAG_0013_DATA_STATIC_WHILE_SET_AT_EXECUTE = 0x00000004,
        D3D12DDI_DESCRIPTOR_RANGE_FLAG_0013_DATA_STATIC = 0x00000008,
        D3D12DDI_DESCRIPTOR_RANGE_FLAG_0052_DESCRIPTORS_STATIC_KEEPING_BUFFER_BOUNDS_CHECKS = 0x00010000,
    }
}
