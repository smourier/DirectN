// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS
    {
        public IntPtr pSrcResource;
        public IntPtr pDstResource;
        public uint SubresourceCount;
        public IntPtr pSubresourceParameters;
        public DXGI_FORMAT Format;
        public D3D12_RESOLVE_MODE ResolveMode;
        public bool PreserveResolveSource;
    }
}
