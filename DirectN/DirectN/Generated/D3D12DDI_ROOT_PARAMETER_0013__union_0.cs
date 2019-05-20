// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(3596,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROOT_PARAMETER_0013__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public D3D12DDI_ROOT_DESCRIPTOR_TABLE_0013 DescriptorTable { get => InteropRuntime.Get<D3D12DDI_ROOT_DESCRIPTOR_TABLE_0013>(__bits, 0, 384); set => InteropRuntime.Set<D3D12DDI_ROOT_DESCRIPTOR_TABLE_0013>(value, __bits, 0, 384); }
        public D3D12DDI_ROOT_CONSTANTS Constants { get => InteropRuntime.Get<D3D12DDI_ROOT_CONSTANTS>(__bits, 0, 96); set => InteropRuntime.Set<D3D12DDI_ROOT_CONSTANTS>(value, __bits, 0, 96); }
        public D3D12DDI_ROOT_DESCRIPTOR_0013 Descriptor { get => InteropRuntime.Get<D3D12DDI_ROOT_DESCRIPTOR_0013>(__bits, 0, 96); set => InteropRuntime.Set<D3D12DDI_ROOT_DESCRIPTOR_0013>(value, __bits, 0, 96); }
    }
}
