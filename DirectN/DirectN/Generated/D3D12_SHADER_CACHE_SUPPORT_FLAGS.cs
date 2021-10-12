﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2339,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_SHADER_CACHE_SUPPORT_FLAGS
    {
        D3D12_SHADER_CACHE_SUPPORT_NONE = 0x00000000,
        D3D12_SHADER_CACHE_SUPPORT_SINGLE_PSO = 0x00000001,
        D3D12_SHADER_CACHE_SUPPORT_LIBRARY = 0x00000002,
        D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_INPROC_CACHE = 0x00000004,
        D3D12_SHADER_CACHE_SUPPORT_AUTOMATIC_DISK_CACHE = 0x00000008,
        D3D12_SHADER_CACHE_SUPPORT_DRIVER_MANAGED_CACHE = 0x00000010,
        D3D12_SHADER_CACHE_SUPPORT_SHADER_CONTROL_CLEAR = 0x00000020,
        D3D12_SHADER_CACHE_SUPPORT_SHADER_SESSION_DELETE = 0x00000040,
    }
}
