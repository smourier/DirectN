// generated from <Windows SDK Path>\um\d3d12umddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_BUFFER_BARRIER_0088
    {
        public D3D12DDI_BARRIER_SYNC SyncBefore;
        public D3D12DDI_BARRIER_SYNC SyncAfter;
        public D3D12DDI_BARRIER_ACCESS AccessBefore;
        public D3D12DDI_BARRIER_ACCESS AccessAfter;
        public D3D10DDI_HRESOURCE hResource;
    }
}
