// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SHADER_CACHE_SESSION_DESC
    {
        public Guid Identifier;
        public D3D12_SHADER_CACHE_MODE Mode;
        public D3D12_SHADER_CACHE_FLAGS Flags;
        public uint MaximumInMemoryCacheSizeBytes;
        public uint MaximumInMemoryCacheEntries;
        public uint MaximumValueFileSizeBytes;
        public ulong Version;
    }
}
