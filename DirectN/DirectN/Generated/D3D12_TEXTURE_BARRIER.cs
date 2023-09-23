// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXTURE_BARRIER
    {
        public D3D12_BARRIER_SYNC SyncBefore;
        public D3D12_BARRIER_SYNC SyncAfter;
        public D3D12_BARRIER_ACCESS AccessBefore;
        public D3D12_BARRIER_ACCESS AccessAfter;
        public D3D12_BARRIER_LAYOUT LayoutBefore;
        public D3D12_BARRIER_LAYOUT LayoutAfter;
        public IntPtr pResource;
        public D3D12_BARRIER_SUBRESOURCE_RANGE Subresources;
        public D3D12_TEXTURE_BARRIER_FLAGS Flags;
    }
}
