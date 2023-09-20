// generated from <Windows SDK Path>\um\d3d12umddi.h
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
