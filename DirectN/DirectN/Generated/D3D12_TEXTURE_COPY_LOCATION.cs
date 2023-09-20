// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXTURE_COPY_LOCATION
    {
        public IntPtr pResource;
        public D3D12_TEXTURE_COPY_TYPE Type;
        public D3D12_TEXTURE_COPY_LOCATION__union_0 __union_2;
    }
}
