// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS_0053
    {
        public D3D10DDI_HRESOURCE hSrcResource;
        public D3D10DDI_HRESOURCE hDstResource;
        public uint SubresourceCount;
        public IntPtr pSubresourceParameters;
        public DXGI_FORMAT Format;
        public D3D12DDI_RESOLVE_MODE ResolveMode;
        public bool PreserveResolveSource;
    }
}
