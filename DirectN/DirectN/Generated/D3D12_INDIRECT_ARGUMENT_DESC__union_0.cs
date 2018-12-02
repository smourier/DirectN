// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(3767,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_INDIRECT_ARGUMENT_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] __bits;
        public D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_0 VertexBuffer => InteropRuntime.Get<D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_0>(__bits, 0, 32);
        public D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_1 Constant => InteropRuntime.Get<D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_1>(__bits, 0, 96);
        public D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_2 ConstantBufferView => InteropRuntime.Get<D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_2>(__bits, 0, 32);
        public D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_3 ShaderResourceView => InteropRuntime.Get<D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_3>(__bits, 0, 32);
        public D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_4 UnorderedAccessView => InteropRuntime.Get<D3D12_INDIRECT_ARGUMENT_DESC__union_0__struct_4>(__bits, 0, 32);
    }
}
