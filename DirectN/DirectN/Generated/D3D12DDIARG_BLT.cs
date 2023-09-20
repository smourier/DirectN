// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDIARG_BLT
    {
        public D3D10DDI_HRESOURCE hDstResource;
        public uint DstSubresource;
        public uint DstLeft;
        public uint DstTop;
        public uint DstRight;
        public uint DstBottom;
        public D3D10DDI_HRESOURCE hSrcResource;
        public uint SrcSubresource;
        public uint SrcLeft;
        public uint SrcTop;
        public uint SrcRight;
        public uint SrcBottom;
        public DXGI_DDI_ARG_BLT_FLAGS Flags;
        public DXGI_DDI_MODE_ROTATION Rotate;
    }
}
