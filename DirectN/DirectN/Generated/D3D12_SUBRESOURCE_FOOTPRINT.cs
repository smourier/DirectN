// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2586,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_SUBRESOURCE_FOOTPRINT
    {
        public DXGI_FORMAT Format;
        public uint Width;
        public uint Height;
        public uint Depth;
        public uint RowPitch;
    }
}
