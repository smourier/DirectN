// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(2420,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_SERIALIZATION
    {
        public uint NodeIndex;
        public D3D12_HEAP_SERIALIZATION_TIER HeapSerializationTier;
    }
}
