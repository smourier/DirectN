// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VERSIONED_DEVICE_REMOVED_EXTENDED_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA Dred_1_0 { get => InteropRuntime.Get<D3D12_DEVICE_REMOVED_EXTENDED_DATA>(__bits, 0, 384); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<D3D12_DEVICE_REMOVED_EXTENDED_DATA>(value, __bits, 0, 384); } }
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA1 Dred_1_1 { get => InteropRuntime.Get<D3D12_DEVICE_REMOVED_EXTENDED_DATA1>(__bits, 0, 512); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<D3D12_DEVICE_REMOVED_EXTENDED_DATA1>(value, __bits, 0, 512); } }
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA2 Dred_1_2 { get => InteropRuntime.Get<D3D12_DEVICE_REMOVED_EXTENDED_DATA2>(__bits, 0, 1152); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<D3D12_DEVICE_REMOVED_EXTENDED_DATA2>(value, __bits, 0, 1152); } }
        public D3D12_DEVICE_REMOVED_EXTENDED_DATA3 Dred_1_3 { get => InteropRuntime.Get<D3D12_DEVICE_REMOVED_EXTENDED_DATA3>(__bits, 0, 1248); set { if (__bits == null) __bits = new byte[64]; InteropRuntime.Set<D3D12_DEVICE_REMOVED_EXTENDED_DATA3>(value, __bits, 0, 1248); } }
    }
}
