// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(2190,9)
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
