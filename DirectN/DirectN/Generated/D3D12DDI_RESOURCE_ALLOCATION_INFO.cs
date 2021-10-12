// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(557,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RESOURCE_ALLOCATION_INFO
    {
        public ulong ResourceDataSize;
        public ulong AdditionalDataHeaderSize;
        public ulong AdditionalDataSize;
        public ulong ResourceDataAlignment;
        public D3D12DDI_RESOURCE_ALLOCATION_INFO__union_0 __union_4;
        public ulong AdditionalDataAlignment;
        public D3D12DDI_TEXTURE_LAYOUT Layout;
        public byte MipLevelSwizzleTransition;
    }
}
