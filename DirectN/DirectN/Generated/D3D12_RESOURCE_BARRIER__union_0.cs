// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2578,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_BARRIER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public byte[] __bits;
        public D3D12_RESOURCE_TRANSITION_BARRIER Transition => InteropRuntime.Get<D3D12_RESOURCE_TRANSITION_BARRIER>(__bits, 0, 160);
        public D3D12_RESOURCE_ALIASING_BARRIER Aliasing => InteropRuntime.Get<D3D12_RESOURCE_ALIASING_BARRIER>(__bits, 0, 128);
        public D3D12_RESOURCE_UAV_BARRIER UAV => InteropRuntime.Get<D3D12_RESOURCE_UAV_BARRIER>(__bits, 0, 64);
    }
}
