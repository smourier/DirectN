// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO
    {
        public DXGI_FORMAT Format;
        public D3D12_RESOURCE_DIMENSION Dimension;
        public D3D12_HEAP_PROPERTIES DestHeapProperties;
        public bool Supported;
    }
}
