// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(3271,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_ROOT_PARAMETER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public D3D12_ROOT_DESCRIPTOR_TABLE DescriptorTable => InteropRuntime.Get<D3D12_ROOT_DESCRIPTOR_TABLE>(__bits, 0, 128);
        public D3D12_ROOT_CONSTANTS Constants => InteropRuntime.Get<D3D12_ROOT_CONSTANTS>(__bits, 0, 96);
        public D3D12_ROOT_DESCRIPTOR Descriptor => InteropRuntime.Get<D3D12_ROOT_DESCRIPTOR>(__bits, 0, 64);
    }
}
