// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2111,9)
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
