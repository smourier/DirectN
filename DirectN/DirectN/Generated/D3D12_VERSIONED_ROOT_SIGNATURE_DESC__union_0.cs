// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(3398,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VERSIONED_ROOT_SIGNATURE_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
        public byte[] __bits;
        public D3D12_ROOT_SIGNATURE_DESC Desc_1_0 => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC>(__bits, 0, 288);
        public D3D12_ROOT_SIGNATURE_DESC1 Desc_1_1 => InteropRuntime.Get<D3D12_ROOT_SIGNATURE_DESC1>(__bits, 0, 288);
    }
}
