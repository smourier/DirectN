// generated from <Windows SDK Path>\um\d3d12.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEPTH_STENCIL_VIEW_DESC
    {
        public DXGI_FORMAT Format;
        public D3D12_DSV_DIMENSION ViewDimension;
        public D3D12_DSV_FLAGS Flags;
        public D3D12_DEPTH_STENCIL_VIEW_DESC__union_0 __union_3;
    }
}
