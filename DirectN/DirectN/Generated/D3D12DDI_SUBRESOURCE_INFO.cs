// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(587,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_SUBRESOURCE_INFO
    {
        public ulong Offset;
        public ulong RowStride;
        public ulong DepthStride;
        public ushort RowBytePreSwizzleOffset;
        public ushort ColumnPreSwizzleOffset;
        public ushort DepthPreSwizzleOffset;
    }
}
