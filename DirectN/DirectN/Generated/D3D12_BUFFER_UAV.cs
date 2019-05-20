// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(3017,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUFFER_UAV
    {
        public ulong FirstElement;
        public uint NumElements;
        public uint StructureByteStride;
        public ulong CounterOffsetInBytes;
        public D3D12_BUFFER_UAV_FLAGS Flags;
    }
}
