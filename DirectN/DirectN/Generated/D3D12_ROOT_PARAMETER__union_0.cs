// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_ROOT_PARAMETER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable { get => InteropRuntime.Get<D3D12_ROOT_DESCRIPTOR_TABLE>(__bits, 0, 320); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12_ROOT_DESCRIPTOR_TABLE>(value, __bits, 0, 320); } }
        public D3D12_ROOT_CONSTANTS Constants { get => InteropRuntime.Get<D3D12_ROOT_CONSTANTS>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12_ROOT_CONSTANTS>(value, __bits, 0, 96); } }
        public D3D12_ROOT_DESCRIPTOR Descriptor { get => InteropRuntime.Get<D3D12_ROOT_DESCRIPTOR>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<D3D12_ROOT_DESCRIPTOR>(value, __bits, 0, 64); } }
    }
}
