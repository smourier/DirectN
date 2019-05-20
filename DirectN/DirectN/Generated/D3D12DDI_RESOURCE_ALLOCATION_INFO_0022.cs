// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4591,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_RESOURCE_ALLOCATION_INFO_0022
    {
        public ulong ResourceDataSize;
        public ulong AdditionalDataHeaderSize;
        public ulong AdditionalDataSize;
        public uint ResourceDataAlignment;
        public uint AdditionalDataHeaderAlignment;
        public uint AdditionalDataAlignment;
        public D3D12DDI_TEXTURE_LAYOUT Layout;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public byte[] MipLevelSwizzleTransition;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public byte[] PlaneSliceSwizzleTransition;
    }
}
