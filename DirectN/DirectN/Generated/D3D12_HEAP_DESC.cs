// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_HEAP_DESC
    {
        public ulong SizeInBytes;
        public D3D12_HEAP_PROPERTIES Properties;
        public ulong Alignment;
        public D3D12_HEAP_FLAGS Flags;
    }
}
