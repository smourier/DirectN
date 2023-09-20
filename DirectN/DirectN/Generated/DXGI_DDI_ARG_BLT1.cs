// generated from <Windows SDK Path>\um\dxgiddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_BLT1
    {
        public ulong hDevice;
        public ulong hDstResource;
        public uint DstSubresource;
        public uint DstLeft;
        public uint DstTop;
        public uint DstRight;
        public uint DstBottom;
        public ulong hSrcResource;
        public uint SrcSubresource;
        public uint SrcLeft;
        public uint SrcTop;
        public uint SrcRight;
        public uint SrcBottom;
        public DXGI_DDI_ARG_BLT_FLAGS Flags;
        public DXGI_DDI_MODE_ROTATION Rotate;
    }
}
