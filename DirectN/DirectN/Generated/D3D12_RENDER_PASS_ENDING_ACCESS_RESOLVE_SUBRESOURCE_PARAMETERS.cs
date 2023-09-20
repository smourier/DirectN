// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS
    {
        public uint SrcSubresource;
        public uint DstSubresource;
        public uint DstX;
        public uint DstY;
        public tagRECT SrcRect;
    }
}
