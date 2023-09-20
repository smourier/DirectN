// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_ARCHITECTURE1
    {
        public uint NodeIndex;
        public bool TileBasedRenderer;
        public bool UMA;
        public bool CacheCoherentUMA;
        public bool IsolatedMMU;
    }
}
