// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2771,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_PLACED_SUBRESOURCE_FOOTPRINT
    {
        public ulong Offset;
        public D3D12_SUBRESOURCE_FOOTPRINT Footprint;
    }
}
