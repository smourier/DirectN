﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(3626,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_DESCRIPTOR_RANGE_FLAGS
    {
        D3D12_DESCRIPTOR_RANGE_FLAG_NONE = 0x00000000,
        D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_VOLATILE = 0x00000001,
        D3D12_DESCRIPTOR_RANGE_FLAG_DATA_VOLATILE = 0x00000002,
        D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC_WHILE_SET_AT_EXECUTE = 0x00000004,
        D3D12_DESCRIPTOR_RANGE_FLAG_DATA_STATIC = 0x00000008,
        D3D12_DESCRIPTOR_RANGE_FLAG_DESCRIPTORS_STATIC_KEEPING_BUFFER_BOUNDS_CHECKS = 0x00010000,
    }
}
