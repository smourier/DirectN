// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_CONTENT_PROTECTION_SYSTEM_SUPPORT_DATA_0030
    {
        public uint NodeIndex;
        public uint ContentProtectionSystemCount;
        public IntPtr pContentProtectionSystems;
    }
}
