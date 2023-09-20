// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_DESC1
    {
        public D3D12_RESOURCE_DIMENSION Dimension;
        public ulong Alignment;
        public ulong Width;
        public uint Height;
        public ushort DepthOrArraySize;
        public ushort MipLevels;
        public DXGI_FORMAT Format;
        public DXGI_SAMPLE_DESC SampleDesc;
        public D3D12_TEXTURE_LAYOUT Layout;
        public D3D12_RESOURCE_FLAGS Flags;
        public D3D12_MIP_REGION SamplerFeedbackMipRegion;
    }
}
