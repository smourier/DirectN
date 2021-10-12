// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(2387,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_0 VertexBuffer { get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_0>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_0>(value, __bits, 0, 32); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_1 Constant { get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_1>(__bits, 0, 96); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_1>(value, __bits, 0, 96); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_2 ConstantBufferView { get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_2>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_2>(value, __bits, 0, 32); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_3 ShaderResourceView { get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_3>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_3>(value, __bits, 0, 32); } }
        public D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_4 UnorderedAccessView { get => InteropRuntime.Get<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_4>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[12]; InteropRuntime.Set<D3D12DDI_INDIRECT_ARGUMENT_DESC__union_0__struct_4>(value, __bits, 0, 32); } }
    }
}
