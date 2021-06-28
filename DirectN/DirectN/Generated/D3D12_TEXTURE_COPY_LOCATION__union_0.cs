// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(2788,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXTURE_COPY_LOCATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint { get => InteropRuntime.Get<D3D12_PLACED_SUBRESOURCE_FOOTPRINT>(__bits, 0, 224); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.Set<D3D12_PLACED_SUBRESOURCE_FOOTPRINT>(value, __bits, 0, 224); } }
        public uint SubresourceIndex { get => InteropRuntime.GetUInt32(__bits, 0, 32); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.SetUInt32(value, __bits, 0, 32); } }
    }
}
