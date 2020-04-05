// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(3471,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 308)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12_ROOT_SIGNATURE_DESC Desc_1_0 { get => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC>(__bits, 0, 2208); set { if (__bits == null) __bits = new byte[308]; InteropRuntime.Set<D3D12_ROOT_SIGNATURE_DESC>(value, __bits, 0, 2208); } }
        public D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1 { get => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC1>(__bits, 0, 2464); set { if (__bits == null) __bits = new byte[308]; InteropRuntime.Set<D3D12_ROOT_SIGNATURE_DESC1>(value, __bits, 0, 2464); } }
    }
}
