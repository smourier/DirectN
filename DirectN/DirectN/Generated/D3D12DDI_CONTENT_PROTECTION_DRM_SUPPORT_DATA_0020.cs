// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_CONTENT_PROTECTION_DRM_SUPPORT_DATA_0020
    {
        public Guid DecodeProfile;
        public Guid ContentProtectionSystem;
        public uint PrependInputDataSize;
        public uint PrependOutputDataSize;
        public uint HardwareKeyDataDataSize;
        public bool fSupported;
    }
}
