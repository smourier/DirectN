// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _D3DKMT_TRACKEDWORKLOAD_SUPPORT
    {
        public uint PhysicalAdapterIndex;
        public DXGK_ENGINE_TYPE EngineType;
        public bool Support;
    }
}
