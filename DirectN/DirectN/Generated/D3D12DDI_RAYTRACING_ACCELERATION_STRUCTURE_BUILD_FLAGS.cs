﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS
    {
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_NONE = 0x00000000,
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_UPDATE = 0x00000001,
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_ALLOW_COMPACTION = 0x00000002,
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_TRACE = 0x00000004,
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PREFER_FAST_BUILD = 0x00000008,
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_MINIMIZE_MEMORY = 0x00000010,
        D3D12DDI_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAG_PERFORM_UPDATE = 0x00000020,
    }
}
