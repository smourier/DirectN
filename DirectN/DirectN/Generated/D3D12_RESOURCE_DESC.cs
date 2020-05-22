// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2544,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_DESC
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
    }
}
