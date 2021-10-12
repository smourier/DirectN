// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(19958,9)
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
