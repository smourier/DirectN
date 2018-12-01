// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2574,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOURCE_BARRIER
    {
        public D3D12_RESOURCE_BARRIER_TYPE Type;
        public D3D12_RESOURCE_BARRIER_FLAGS Flags;
        public D3D12_RESOURCE_BARRIER__union_0 __union_2;
    }
}
