﻿// generated from <Windows SDK Path>\um\d3d12umddi.h
namespace DirectN
{
    public enum D3D12DDI_BARRIER_ACCESS
    {
        D3D12DDI_BARRIER_ACCESS_COMMON = 0,
        D3D12DDI_BARRIER_ACCESS_VERTEX_BUFFER = 1,
        D3D12DDI_BARRIER_ACCESS_CONSTANT_BUFFER = 2,
        D3D12DDI_BARRIER_ACCESS_INDEX_BUFFER = 4,
        D3D12DDI_BARRIER_ACCESS_RENDER_TARGET = 8,
        D3D12DDI_BARRIER_ACCESS_UNORDERED_ACCESS = 16,
        D3D12DDI_BARRIER_ACCESS_DEPTH_STENCIL_WRITE = 32,
        D3D12DDI_BARRIER_ACCESS_DEPTH_STENCIL_READ = 64,
        D3D12DDI_BARRIER_ACCESS_SHADER_RESOURCE = 128,
        D3D12DDI_BARRIER_ACCESS_STREAM_OUTPUT = 256,
        D3D12DDI_BARRIER_ACCESS_INDIRECT_ARGUMENT = 512,
        D3D12DDI_BARRIER_ACCESS_PREDICATION = 512,
        D3D12DDI_BARRIER_ACCESS_COPY_DEST = 1024,
        D3D12DDI_BARRIER_ACCESS_COPY_SOURCE = 2048,
        D3D12DDI_BARRIER_ACCESS_RESOLVE_DEST = 4096,
        D3D12DDI_BARRIER_ACCESS_RESOLVE_SOURCE = 8192,
        D3D12DDI_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_READ = 16384,
        D3D12DDI_BARRIER_ACCESS_RAYTRACING_ACCELERATION_STRUCTURE_WRITE = 32768,
        D3D12DDI_BARRIER_ACCESS_SHADING_RATE_SOURCE = 65536,
        D3D12DDI_BARRIER_ACCESS_VIDEO_DECODE_READ = 131072,
        D3D12DDI_BARRIER_ACCESS_VIDEO_DECODE_WRITE = 262144,
        D3D12DDI_BARRIER_ACCESS_VIDEO_PROCESS_READ = 524288,
        D3D12DDI_BARRIER_ACCESS_VIDEO_PROCESS_WRITE = 1048576,
        D3D12DDI_BARRIER_ACCESS_VIDEO_ENCODE_READ = 2097152,
        D3D12DDI_BARRIER_ACCESS_VIDEO_ENCODE_WRITE = 4194304,
        D3D12DDI_BARRIER_ACCESS_NO_ACCESS = -2147483648,
    }
}
