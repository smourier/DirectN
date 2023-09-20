// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE
    {
        public ulong StartAddress;
        public ulong SizeInBytes;
        public ulong StrideInBytes;
    }
}
