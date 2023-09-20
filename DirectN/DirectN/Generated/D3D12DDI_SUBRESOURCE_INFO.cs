// generated from <Windows SDK Path>\um\d3d12umddi.h
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
