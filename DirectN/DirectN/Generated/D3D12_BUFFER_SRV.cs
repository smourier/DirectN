// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_BUFFER_SRV
    {
        public ulong FirstElement;
        public uint NumElements;
        public uint StructureByteStride;
        public D3D12_BUFFER_SRV_FLAGS Flags;
    }
}
