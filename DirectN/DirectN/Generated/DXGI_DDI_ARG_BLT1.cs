// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(265,9)
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
